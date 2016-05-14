using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using PrintOrder.Manager;

namespace PrintOrder
{
    public partial class OrderDetails : Form
    {

        ReportDocument crDocument = new ReportDocument();
        private string OrderNumber;
        public OrderDetails(string OrderNumber)
        {
            InitializeComponent();
            this.OrderNumber = OrderNumber;
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {

            //crDocument.Load("C:\\Users\\berka\\Documents\\Visual Studio 2015\\Projects\\PrintOrder\\PrintOrder\\crpt_A4.rpt");
            crDocument.Load("crpt_A4.rpt");
            //DataSet st = new DataSet();
            crDocument.SetDataSource(ConnectionManager.Instance.GetOrderDetails(OrderNumber));
            crDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            crDocument.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            
            crystalReportViewer1.ReportSource = crDocument;
            crDocument.PrintToPrinter(1, true, 0, 0);
        }
    }
}
