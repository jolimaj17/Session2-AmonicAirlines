using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Session2
{
    public partial class Apply : Form
    {

        SQLConnect r = new SQLConnect();
        String sql;
        String delimeter,filename,alldata,name;
        String[] items,rows;

        private void Results_Enter(object sender, EventArgs e)
        {

        }

        public Apply()
        {
            InitializeComponent();
        }

        private void Apply_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            //code for browse
            openFileDialog1.Filter = "csv|";
            txtfilename.Text = openFileDialog1.FileName;
            openFileDialog1.ShowDialog();

            if(txtfilename.Text== openFileDialog1.Filter)
            {
                displaytoDG();
            }

            else
            {
                MessageBox.Show("Invalid format!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void displaytoDG()
        {
            //delimeter = ",";
            //name = "Schedule";
            //filename = txtfilename.Text;
            //DataSet d = new DataSet();
            //StreamReader sr = new StreamReader(filename);
            //alldata = sr.ReadToEnd();
            //rows = alldata.Split("\n".ToCharArray());
            //foreach (string r in rows)
            //{
            //    rows = r.Split(delimeter.ToArray());
                



            }
            //dataGridView1.DataSource = d.Tables[0].DefaultView;
        }
    }

