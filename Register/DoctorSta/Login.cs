using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Register;

namespace DoctorSta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //testing
            textBox_doc.Text = "外科医生1";
            textBox_psd.Text = "123";

        }
        public static string doc;
        private void   button1_Click(object sender, EventArgs e)
        {
            
            if (textBox_psd.Text == "123")
            {             
                doc = textBox_doc.Text;
                DUI dUI = new DUI();
                dUI.Show();
            }
            else
                MessageBox.Show("密码错误");
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_doc.Text = "";
            textBox_psd.Text = "";
        }
    }
}
