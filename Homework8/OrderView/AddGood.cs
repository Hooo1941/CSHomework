using System;
using System.Windows.Forms;
using OrderManager;

namespace OrderView
{
    public partial class AddGood : Form
    {
        private readonly string name = "";
        public AddGood()
        {
            InitializeComponent();
        }

        public AddGood(OrderDetails good):this()
        {
            name = good.Good.Name;
            txtName.Text = name;
            nudPrice.Value = (decimal) good.Good.Price;
            nudAmount.Value = good.Amount;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("货物名不能为空");
                return;
            }
            var g = new Good(txtName.Text, (double) nudPrice.Value);
            var od = new OrderDetails(g, (int)nudAmount.Value);
            if (name != "") AddOrder.Goods.Remove(new OrderDetails(new Good(name,1),1));
            AddOrder.Goods.Add(od);
            this.Close();
        }
    }
}
