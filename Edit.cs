using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2
{
    public partial class Edit : Form
    {
        SQLConnect r = new SQLConnect();
        String sql;

        public DataGridViewRow dv;
        public Edit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ManageFlight a = new ManageFlight();
            a.Show();
            this.Hide();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            lblFrom.Text = dv.Cells["From"].Value.ToString();
            lblTo.Text = dv.Cells["To"].Value.ToString();
            lblair.Text = dv.Cells["Aircraft"].Value.ToString();
            outboundate.Text = dv.Cells["Date"].Value.ToString();
            txtime.Text = dv.Cells["Time"].Value.ToString();
            txtprice.Text = dv.Cells["Economy Price"].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            sql = "Update Schedules set Date='" + outboundate.Value.ToString("yyyMMdd") + "',Time='" + txtime.Text + "',EconomyPrice='" + txtprice.Text + "' where ID='" + dv.Cells["ID"].Value.ToString()+"'";
            r.Modify(sql);
            MessageBox.Show("Successfully Update!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ManageFlight a = new ManageFlight();
            a.Show();
            this.Hide();
        }
    }
}
