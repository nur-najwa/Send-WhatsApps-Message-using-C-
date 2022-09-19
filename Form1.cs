using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendWhatsAppMessageFromCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendWhatsApp(string number, string message)
        {
            try
            {
                if (number == "")
                {
                    MessageBox.Show("No Number Added");
                }
                if(number.Length <= 0)
                {
                    number = "+60" + number;
                }
                number = number.Replace(" ", "");
                System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone-" +number + "&text=" +message);   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sendWhatsApp(txtNumber.Text, txtMessage.Text);
            clearTextbox();
        }
        public void clearTextbox()
        {
            txtMessage.Text = "";
            txtNumber.Text = "";
        }
    }
}
