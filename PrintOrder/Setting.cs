
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using PrintOrder.Manager;
using PrintOrder.Model;

namespace PrintOrder
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        #region Methods

        private void ControlComponents()
        {
            if (textBoxServer.Text == "" && textBoxDatabase.Text == "" && textBoxServer.Text == "" && textBoxUsername.Text == "" && textBoxPassword.Text == "" && comboBoxProgram.SelectedIndex > -1)
            {
                labelInfo.Text = "Please fill all details...";
            }
            else
            {
                string connectionstring = string.Format("Data Source ={0},{1}; initial catalog={2}; user id ={3}; password={4}",
                       textBoxServer.Text.Trim(),
                       textBoxPort.Text.Trim(),
                       textBoxDatabase.Text.Trim(),
                       textBoxUsername.Text.Trim(),
                       textBoxPassword.Text.Trim());
                try
                {
                    using (var sqlCon = new SqlConnection(connectionstring))
                    {
                        sqlCon.Open();
                        sqlCon.Close();
                    }
                    MessageBox.Show("Test Başarılı", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Test Başarısız \n Hata : ", ex.Message), "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void WriteToFile()
        {
            var configuration = new Configuration()
            {
                Server = textBoxServer.Text.Trim(),
                Port = textBoxPort.Text.Trim(),
                Database = textBoxDatabase.Text.Trim(),
                Username = textBoxUsername.Text.Trim(),
                Password = textBoxPassword.Text.Trim(),
                Program = comboBoxProgram.GetItemText(comboBoxProgram.SelectedItem)
            };
            ConfigurationManager.Instance.CreateOrUpdate(configuration);
        }

        private void FillConfiguration()
        {
            var configuration = ConfigurationManager.Instance.Get();
            if (configuration != null)
            {
                try
                {
                    textBoxServer.Text = configuration.Server;
                    textBoxPort.Text = configuration.Port;
                    textBoxDatabase.Text = configuration.Database;
                    textBoxUsername.Text = configuration.Username;
                    textBoxPassword.Text = configuration.Password;
                    FillActiveProgram(comboBoxProgram);
                    if (!string.IsNullOrEmpty(configuration.Program))
                    {
                        comboBoxProgram.Text = configuration.Program;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Ayar dosyası bozuk \n Hata : {0}", ex.Message), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void FillActiveProgram(ComboBox cmb)
        {
            var activeprograms = ConnectionManager.Instance.GetActivePrograms();
            if (activeprograms != null && activeprograms.Count > 0)
            {
                activeprograms.Insert(0, new ActiveProgram() { Name = "Seçiniz", Version = string.Empty });
                cmb.DataSource = activeprograms;
                cmb.ValueMember = "Name";
                cmb.DisplayMember = "Name";
            }
        }

        #endregion

        #region Components

        private void buttonTest_Click(object sender, EventArgs e)
        {
            ControlComponents();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            WriteToFile();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            FillConfiguration();
        }

        #endregion

    }
}
