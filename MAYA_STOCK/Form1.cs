using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAYA_STOCK.ENTITIES;

namespace MAYA_STOCK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            /***************************************************************/
            /*connection string */
            DataContext A = new DataContext("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\maya\MAYA_STOCK\My_DB\STOCK_DB.mdf;Integrated Security=True");
            var class1s = A.GetTable<Class1>();
           /****************************************************/


            var mdata = from data in class1s where data.USER_ID == 1 select data;
            if (mdata.Any())
            {
               bool a= mdata.ToList()[0].password == "pass";
            }

            MessageBox.Show("abu rafeeq kiss my ass");
        }
    }
}
