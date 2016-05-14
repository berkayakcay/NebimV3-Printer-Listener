using System;
using System.Windows.Forms;
using System.Collections;
using PrintOrder.Model;
using PrintOrder.Manager;
using System.Timers;
using System.Threading;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace PrintOrder
{
    public partial class Main : Form
    {
        #region Cons Vars

        public Main()
        {
            InitializeComponent();


        }


        #endregion


        #region TrayIcon
        private void Main_Resize(object sender, System.EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                ShowInTaskbar = false;
                Hide();
            }
            else
            {
                ShowInTaskbar = true;
            }
        }

        private void nIPrinterListener_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        #endregion

        #region Methods

        private void Main_Load(object sender, EventArgs e)
        {

            dataGridViewOrders.DataSource = ConnectionManager.Instance.GetPrintingOrders();
            timerRefresh.Stop();
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            sqlRefresh();
        }

        private void sqlRefresh()
        {
            List<OrderPrint> ordernumbers = ConnectionManager.Instance.GetPrintingOrders();
            dataGridViewOrders.DataSource = ordernumbers;
            foreach (var item in ordernumbers)
            {
                OrderDetails ordet = new OrderDetails(item.OrderNumber);
                ordet.Show();
            }
        }

        private string ConcatOrderNumber(string OrderNumber)
        {
            return string.Concat("1-WS-2-", OrderNumber);
        }

        #endregion

        #region Components

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //OrderDetails details = new OrderDetails(dataGridViewOrders.Rows[dataGridViewOrders.CurrentCell.RowIndex].Cells[dataGridViewOrders.CurrentCell.ColumnIndex].Value.ToString());
            //details.Show();
            if (buttonPrint.Text == "STOPPED")
            {
                buttonPrint.Text = "STARTED";
                buttonPrint.BackColor = System.Drawing.Color.Green;
                timerRefresh.Start();
            }
            else
            {
                buttonPrint.Text = "STOPPED";
                buttonPrint.BackColor = System.Drawing.Color.Red;
                timerRefresh.Stop();
            }
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            Setting formSettings = new Setting();
            formSettings.Show();
        }

        private void nIPrinterListener_MouseMove(object sender, MouseEventArgs e)
        {
            nIPrinterListener.Text = string.Concat("Print Listener has been ", buttonPrint.Text, " !");
        }

        private void buttonPrintAgain_Click(object sender, EventArgs e)
        {
            if (textBoxOrderNumber.Text == "")
            {
                MessageBox.Show("Plese input 'Order Number' without 1-WS-2- part","info",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (ConnectionManager.Instance.CheckOrderNumber(ConcatOrderNumber(textBoxOrderNumber.Text.Trim().ToString())))
                {
                    OrderDetails ordet = new OrderDetails(ConcatOrderNumber(textBoxOrderNumber.Text.Trim().ToString()));
                    ordet.Show();
                }
                else
                {
                    MessageBox.Show("Could not find any order","info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textBoxOrderNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        #endregion


    }
}
