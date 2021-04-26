using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OrderManager;

namespace OrderView
{
    public partial class OrderView : Form
    {
        public static readonly OrderService orderService = new();
        private IEnumerable<Order> searchOrders;
        public OrderView()
        {
            InitializeComponent();
        }

        private void dgvOrder_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

        private void OrderView_Load(object sender, EventArgs e)
        {
            bdsOrder.DataSource = orderService.orders;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            orderService.Import();
            bdsOrder.DataSource = orderService.orders;
            bdsOrder.ResetBindings(false);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            orderService.Export();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            var currentRow = bdsOrder.Current;
            orderService.DeleteOrder(((Order) currentRow).Id);
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var ao = new AddOrder();
            ao.ShowDialog(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearch.SelectedItem.ToString() == "") return;
            if (cmbSearch.SelectedItem.ToString() == "订单号")
            {
                if (!int.TryParse(txtSearch.Text, out var id))
                {
                    MessageBox.Show("请输入整数", "提示");
                    return;
                }

                searchOrders = orderService.Query(o => o.Id == id);

            }
            else //用户名
                searchOrders = orderService.Query(o => o.Customer == txtSearch.Text);
            bdsOrder.DataSource = searchOrders;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            bdsOrder.DataSource = orderService.orders;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var currentRow = bdsOrder.Current;
            var ao = new AddOrder(((Order)currentRow).Id);
            ao.ShowDialog(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bdsOrder.ResetBindings(false);
        }
    }
}
