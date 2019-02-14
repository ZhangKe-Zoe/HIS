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
    public partial class UI : Form
    {
       
        
        public UI()
        {
            InitializeComponent();
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        //save register imformathion
        private void button_save_Click(object sender, EventArgs e)
        {

            {
                if  (textBox_name.Text != null)
                {
                    //connect to the  database
                    DAL BD = new DAL();
                    BD.ConnDB();

                    //insert data 
                    Register re = new Register();
                    re.zlk = textBox_zlk.Text;
                    re.mz = textBox_mz.Text;
                    re.name = textBox_name.Text;
                    re.age = textBox_age.Text;
                    re.sr = dateTimePicker_sr.Value.ToShortDateString();
                    re.cid = textBox_cid.Text;
                    re.sex = comboBox_sex.Text;
                    re.nat = comboBox_nat.Text;
                    re.tel = textBox_tel.Text;
                    re.regs = comboBox_rs.Text;
                    re.chas = comboBox_chas.Text;
                    re.dep = comboBox_dep.Text;
                    re.doc = comboBox_doc.Text;
                    re.rdate = dateTimePicker_rdate.Text;
                    re.rtime = comboBox_rtime.Text;
                    re.pay = textBox_pay.Text;

                    BD.insert(re);

                    //error 
                    BD.TC();
                    BD.myconn.Close();
                    MessageBox.Show("挂号成功！");
                }
                else
                    MessageBox.Show("输入值不可为空");
            }

        }


        private void button_read_Click(object sender, EventArgs e)
        {
            zlk form = new zlk();
            form.Show();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_zlk.Text = "";
            textBox_mz.Text = "";
            textBox_name.Text = "";
            textBox_age.Text = "";
            textBox_cid.Text = "";
            textBox_tel.Text = "";
            textBox_pay.Text = "";
            comboBox_sex.Text = "";
            comboBox_nat.Text = "";
            comboBox_dep.Text = "";
            comboBox_doc.Text = "";
            comboBox_chas.Text = "";
            comboBox_rs.Text = "";
        }

        //according to the departement to auto adjust available doctors 
        private void comboBox_dep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_dep.SelectedItem.ToString() == "外科")
            {
                comboBox_doc.Items.Clear();
                comboBox_doc.Items.Add("外科医生1");
                comboBox_doc.Items.Add("外科医生2");
      
            }
            else if (comboBox_dep.SelectedItem.ToString() == "内科")
            {
                comboBox_doc.Items.Clear();
                comboBox_doc.Items.Add("内科医生1");
                comboBox_doc.Items.Add("内科医生2");

            }
            else if (comboBox_dep.SelectedItem.ToString() == "妇产科")
            {
                comboBox_doc.Items.Clear();
                comboBox_doc.Items.Add("妇产科医生1");
                comboBox_doc.Items.Add("妇产科医生2");

            }
            else if (comboBox_dep.SelectedItem.ToString() == "传染科")
            {
                comboBox_doc.Items.Clear();
                comboBox_doc.Items.Add("传染科医生1");
                comboBox_doc.Items.Add("传染科医生2");
            }

        }
        //clrea the screen
        private void button_clear_d_Click(object sender, EventArgs e)
        {
            textBox_zlk_d.Text = "";
            textBox_mz_d.Text = "";
            textBox_name_d.Text = "";
            textBox_age_d.Text = "";
            textBox_cid_d.Text = "";
            textBox_pay_d.Text = "";
            textBox_sex_d.Text = "";
            textBox_nat_d.Text = "";
            textBox_dep_d.Text = "";
            textBox_doc_d.Text = "";
            textBox_chas_d.Text = "";
            textBox_rs_d.Text = "";
            textBox_sr_d.Text = "";

        }
        //delete the register information
        private void button_del_Click(object sender, EventArgs e)
        {

            DAL BD = new DAL();
            BD.ConnDB();
            Register re = new Register();
            re.mz = textBox_mz_d.Text;
            BD.delect(re.mz);

            //error
            BD.TC();
            BD.myconn.Close();
            MessageBox.Show("退号成功！");

        }

        //read the register information
        private void button_read_d_Click(object sender, EventArgs e)
        {
            DAL BD = new DAL();
            BD.ConnDB();
            Register re = new Register();
            re.mz = textBox_mz_d.Text;

            BD.show(re.mz, "zlk");
            if (BD.mycmd.ExecuteScalar() != null)
                textBox_zlk_d.Text = BD.mycmd.ExecuteScalar().ToString();
            else
            {
                MessageBox.Show("查无此号，请重新输入");

            }

            BD.show(re.mz, "name");
            if (BD.mycmd.ExecuteScalar() != null)
                textBox_name_d.Text = BD.mycmd.ExecuteScalar().ToString();
            BD.show(re.mz, "age");
            if (BD.mycmd.ExecuteScalar() != null)
                textBox_age_d.Text = BD.mycmd.ExecuteScalar().ToString();
            BD.show(re.mz, "sr");
            if (BD.mycmd.ExecuteScalar() != null)
                textBox_sr_d.Text = BD.mycmd.ExecuteScalar().ToString();
            BD.show(re.mz, "cid");
            if (BD.mycmd.ExecuteScalar() != null)
                textBox_cid_d.Text = BD.mycmd.ExecuteScalar().ToString();
            BD.show(re.mz, "sex");
            if (BD.mycmd.ExecuteScalar() != null)
                textBox_sex_d.Text = BD.mycmd.ExecuteScalar().ToString();
            BD.show(re.mz, "nat");
            if (BD.mycmd.ExecuteScalar() != null)
                textBox_nat_d.Text = BD.mycmd.ExecuteScalar().ToString();
            BD.show(re.mz, "dep");
            if (BD.mycmd.ExecuteScalar() != null)
                textBox_dep_d.Text = BD.mycmd.ExecuteScalar().ToString();
            BD.show(re.mz, "doc");
            if (BD.mycmd.ExecuteScalar() != null)
                textBox_doc_d.Text = BD.mycmd.ExecuteScalar().ToString();
            BD.show(re.mz, "rtime");
            if (BD.mycmd.ExecuteScalar() != null)
               comboBox_rtime_d.Text = BD.mycmd.ExecuteScalar().ToString();
            BD.show(re.mz, "rdate");
            if (BD.mycmd.ExecuteScalar() != null)
                dateTimePicker_rdate_d.Text = BD.mycmd.ExecuteScalar().ToString();
            BD.show(re.mz, "regs");
            if (BD.mycmd.ExecuteScalar() != null)
                textBox_rs_d.Text = BD.mycmd.ExecuteScalar().ToString();
            BD.show(re.mz, "chas");
            if (BD.mycmd.ExecuteScalar() != null)
                textBox_chas_d.Text = BD.mycmd.ExecuteScalar().ToString();
            BD.show(re.mz, "pay");
            if (BD.mycmd.ExecuteScalar() != null)
                textBox_pay_d.Text = BD.mycmd.ExecuteScalar().ToString();
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("有任何问题请联系管理员，谢谢！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("有任何问题请联系管理员，谢谢！");
        }
        //read the medical information to the register form
        private void textBox_zlk_TextChanged(object sender, EventArgs e)
        {
            string zlk = textBox_zlk.Text;
            DAL db = new DAL();
            db.ConnDB();
            db.showzlk(zlk, "zlk");
            if (db.mycmd.ExecuteScalar() == null)
            {
                MessageBox.Show("无此档案，请重新输入");
            }
            else
            {
                db.showzlk(zlk, "name");
                textBox_name.Text = db.mycmd.ExecuteScalar().ToString();
                db.showzlk(zlk, "sex");
                comboBox_sex.Text = db.mycmd.ExecuteScalar().ToString();
                db.showzlk(zlk, "age");
                textBox_age.Text = db.mycmd.ExecuteScalar().ToString();
                db.showzlk(zlk, "sr");
                dateTimePicker_sr.Text = db.mycmd.ExecuteScalar().ToString();
                db.showzlk(zlk, "cid");
                textBox_cid.Text = db.mycmd.ExecuteScalar().ToString();
                db.showzlk(zlk, "tel");
                textBox_tel.Text = db.mycmd.ExecuteScalar().ToString();
            }
        }

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
