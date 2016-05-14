using System;

using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PrintOrder.Model;

namespace PrintOrder.Manager
{
    public class ConnectionManager
    {

        private static ConnectionManager _instance = new ConnectionManager();
        private static readonly object _lockObject = new object();

        public static ConnectionManager Instance
        {
            get
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new ConnectionManager();
                    }
                    return _instance;
                }
            }
        }

        public ConnectionManager()
        {
        }

        public string ConnectionString
        {
            get
            {
                if (ConfigurationManager.Instance.Configuration != null)
                {
                    return string.Format("Data Source ={0},{1}; initial catalog={2}; user id ={3}; password={4}",
                       ConfigurationManager.Instance.Configuration.Server,
                       ConfigurationManager.Instance.Configuration.Port,
                       ConfigurationManager.Instance.Configuration.Database,
                       ConfigurationManager.Instance.Configuration.Username,
                       ConfigurationManager.Instance.Configuration.Password
                       );
                }
                return null;
            }
        }

        public void ConnectionTest()
        {
            try
            {
                using (var sqlCon = new SqlConnection(ConnectionString))
                {
                    sqlCon.Open();
                    sqlCon.Close();
                }
                MessageBox.Show("Test sorunsuz bir şekilde gerçekleştirildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Belirtilen parametreler hatalı.\n Hata : {0}", ex.Message));
            }
        }

        public void UpdatePrintedOrders(string OrderNumber)
        {
            using (var sqlCon = new SqlConnection(ConnectionString))
            {
                using (var sqlCommand = new SqlCommand(@"UPDATE "))
                {

                }
            }
        }

        public List<OrderPrint> GetPrintingOrders()
        {
            List<OrderPrint> printlist = null;
            try
            {
                using (var sqlCon = new SqlConnection(ConnectionString))
                {
                    using (var sqlCommand = new SqlCommand(@"SELECT * FROM xlPrintingOrders WHERE IsPrinted = 0", sqlCon))
                    {
                        sqlCon.Open();
                        using (IDataReader dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            printlist = new List<OrderPrint>();

                            while (dr.Read())
                            {
                                printlist.Add(new OrderPrint()
                                {
                                    OrderNumber = dr["OrderNumber"].ToString(),
                                    DocumentNumber = dr["DocumentNumber"].ToString(),
                                    IsPrinted = dr.IsDBNull(dr.GetOrdinal("IsPrinted")) ? false : dr.GetBoolean(dr.GetOrdinal("IsPrinted"))
                            });
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yüklenirken hata oluştu.\n Hata:{0}", ex.Message);
            }
            return printlist;
        }

        public bool CheckOrderNumber(string OrderNumber)
        {
            try
            {
                using (var sqlCon = new SqlConnection(ConnectionString))
                {
                    using (var sqlCommand = new SqlCommand(@"SELECT OrderNumber FROM trOrderHeader WHERE OrderNumber=@OrderNumber",sqlCon))
                    {
                        sqlCommand.Parameters.AddWithValue("@OrderNumber", OrderNumber);
                        sqlCon.Open();
                        using (IDataReader dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Bir hata oluştur \n Hata : ",this.GetType().ToString(), ex.Message));
                return false;
            }


            return false;
        }

        public List<OrderDetail> GetOrderDetails(string OrderNumber)
        {
            List<OrderDetail> orderdetails = null;
            try
            {
                using (var sqlCon = new SqlConnection(ConnectionString))
                {
                    using (var sqlCommand = new SqlCommand(@"SELECT OrderNumber, DocumentNumber, Description, CurrAccCode, ItemCode, ColorCode, SUM(Qty1) AS Qty1 , SUM(Loc_Price) AS Loc_Price, SUM(Loc_NetAmount) AS Loc_NetAmount FROM AllOrders WHERE OrderNumber=@OrderNumber GROUP BY OrderNumber, DocumentNumber, Description, CurrAccCode, ItemCode, ColorCode", sqlCon))
                    {
                        sqlCommand.Parameters.AddWithValue("@OrderNumber", OrderNumber);
                        sqlCon.Open();
                        using (IDataReader dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            orderdetails = new List<OrderDetail>();

                            while (dr.Read())
                            {
                                orderdetails.Add(new OrderDetail()
                                {
                                    OrderNumber = dr["OrderNumber"].ToString(),
                                    DocumentNumber = dr["DocumentNumber"].ToString(),
                                    Description = dr["Description"].ToString(),
                                    CurrAccCode = dr["CurrAccCode"].ToString(),
                                    ItemCode = dr["ItemCode"].ToString(),
                                    ColorCode = dr["ColorCode"].ToString(),
                                    Qty1= Convert.ToInt32(dr["Qty1"]),
                                    Loc_Price =  Convert.ToDecimal(dr["Loc_Price"]),
                                    Loc_NetAmount = Convert.ToDecimal(dr["Loc_NetAmount"])
                                });
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yüklenirken hata oluştu.\n Hata:{0}", ex.Message);
            }
            return orderdetails;
        }

        public List<ActiveProgram> GetActivePrograms()
        {
            List<ActiveProgram> activeprograms = null;

            activeprograms = new List<ActiveProgram>();
            activeprograms.Add(new ActiveProgram()
            {
                Name = "Nebim V3",
                Version = "10.0"
            });

            activeprograms.Add(new ActiveProgram()
            {
                Name = "Nebim Winner",
                Version = "1.0"
            });
            return activeprograms;
        }

    }
}
