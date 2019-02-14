using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class zlk : Form
    {
        public zlk()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //savze medical card infomation
        private void button_fc_Click(object sender, EventArgs e)
        {
            DAL BD = new DAL();
            BD.ConnDB();
            Register zkl = new Register();
            zkl.zlk = textBox_zlk.Text;
            zkl.name = textBox_name.Text;
            zkl.age = textBox_age.Text;
            zkl.sr = dateTimePicker_sr.Value.ToShortDateString();
            zkl.cid = textBox_cid.Text;
            zkl.sex = comboBox_sex.Text;
            zkl.tel = textBox_tel.Text;

            BD.mysql = "insert into zlk (zlk,name,age,sr,cid,sex,tel) " +
            "values('" + zkl.zlk + "','" + zkl.name + "','" + zkl.age + "','" + zkl.sr + "','" + zkl.cid + "'" +
            ",'" + zkl.sex + "','" + zkl.tel + "') ";
            BD.mycmd.CommandText = BD.mysql;
            BD.mycmd.Connection = BD.myconn;
            BD.mycmd.ExecuteNonQuery();

            BD.TC();
            BD.myconn.Close();
            MessageBox.Show("发卡成功！");

        }

        private void button_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("有任何问题请联系管理员，谢谢！");
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_zlk.Text = "";
            textBox_name.Text = "";
            textBox_age.Text = "";
            textBox_cid.Text = "";
            comboBox_sex.Text = "";
            textBox_tel.Text = "";
        }
        //auto choose birthday
        private void textBox_age_DoubleClick(object sender, EventArgs e)
        {
            string age = textBox_age.Text;
            string now = DateTime.Now.ToString("yyyy");
            string sr = (int.Parse(now) - int.Parse(age)).ToString();
            string ssr = sr + "年1月1日";
            dateTimePicker_sr.Text = ssr;
        }

    }
}
