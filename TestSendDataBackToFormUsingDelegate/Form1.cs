using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSendDataBackToFormUsingDelegate
{
    public partial class frmDataReciver : Form
    {
        public frmDataReciver()
        {
            InitializeComponent();
        }

        private void btnOpenFormTwo_Click(object sender, EventArgs e)
        {
            frmDataSender form2 = new frmDataSender();

            form2.DataBack += Form2_DataBack;

            form2.ShowDialog();
        }

        private void Form2_DataBack(object sender, ValueRecivedEventArgs e)
        {
            tboxFormTwoReturnValue.Text = e.Value.ToString();
        }
    }
}
