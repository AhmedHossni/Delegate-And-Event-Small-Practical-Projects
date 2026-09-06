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
    public partial class frmDataSender : Form
    {
        public delegate void SendDataBackHandler(object sender, ValueRecivedEventArgs e);

        public event SendDataBackHandler DataBack;

        public frmDataSender()
        {
            InitializeComponent();
        }

        private void btnReturnValue_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tboxValue.Text, out int value))
            {
                ValueRecivedEventArgs valueRecived = 
                    new ValueRecivedEventArgs (value);
                                      
                DataBack?.Invoke(this, valueRecived);

                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a number not any thing else",
                    "Type Error :(",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

    }
}
