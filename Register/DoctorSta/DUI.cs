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
using System.Data.SqlClient;

namespace DoctorSta
{
    public partial class DUI : Form
    {
        public DUI()
        {
            InitializeComponent();
            this.button_read_Click(null, null);
            this.textBox_doc.Text = Login.doc;

        }
        //候诊接诊
        private void button_jz_Click_1(object sender, EventArgs e)
        {
            Register.Register re = new Register.Register();
            try
            {
                re.mz = this.dataGridView_jz.CurrentRow.Cells[0].Value.ToString();
                textBox_mz_e.Text = re.mz;

                //textBox_mz_zd.Text = re.mz;

                DAL BD = new DAL();
                BD.ConnDB();

                BD.show(re.mz, "zlk");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    textBox_zlk_zd.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_zlk_e.Text = BD.mycmd.ExecuteScalar().ToString();
                }

                else
                {
                    MessageBox.Show("查无此号，请重新接诊");

                }
                //诊断日期
                textBox_zddate.Text = DateTime.Now.ToLocalTime().ToString();

                BD.show(re.mz, "name");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    textBox_name_e.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_name_zd.Text = BD.mycmd.ExecuteScalar().ToString();
                }

                BD.show(re.mz, "age");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    textBox_age_zd.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_age_e.Text = BD.mycmd.ExecuteScalar().ToString();
                }

                BD.show(re.mz, "sr");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    textBox_zddate.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_sr_e.Text = BD.mycmd.ExecuteScalar().ToString();
                }

                BD.show(re.mz, "cid");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    //textBox_cid_zd.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_cid_e.Text = BD.mycmd.ExecuteScalar().ToString();
                }

                BD.show(re.mz, "sex");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    textBox_sex_zd.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_sex_e.Text = BD.mycmd.ExecuteScalar().ToString();
                }

                BD.show(re.mz, "nat");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    //textBox_nation_zd.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_nat_e.Text = BD.mycmd.ExecuteScalar().ToString();
                }

                BD.show(re.mz, "dep");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    //textBox_dp_zd.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_dep_e.Text = BD.mycmd.ExecuteScalar().ToString();
                }

                BD.show(re.mz, "doc");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    //textBox_doc_zd.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_doc_e.Text = BD.mycmd.ExecuteScalar().ToString();
                }

                BD.show(re.mz, "chas");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    //textBox_chas_zd.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_chas_e.Text = BD.mycmd.ExecuteScalar().ToString();
                }

                richTextBox_zs.ReadOnly = false;
                richTextBox_xbs.ReadOnly = false;
                richTextBox_jws.ReadOnly = true;

                MessageBox.Show("接诊成功，请开始诊断");
            }
            catch { MessageBox.Show("无效操作！"); }

        }
        //候诊刷新
        private void button_read_Click(object sender, EventArgs e)
        {
            string doc = Login.doc;
            string ddate = dateTimePicker_ddate.Text;
            string dtime = comboBox_dtime.Text;
            DAL BD = new DAL();
            this.dataGridView_jz.DataMember = "";
            BD.GridviewJZ(doc, dtime, ddate);
            this.dataGridView_jz.DataSource = BD.dataset;
            this.dataGridView_jz.DataMember = "register";

            //error
            BD.TC();
            BD.myconn.Close();
            MessageBox.Show("更新成功！");

        }
       
        private void DUI_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“registerDataSet1.zd”中。您可以根据需要移动或删除它。
            //this.zdTableAdapter.Fill(this.registerDataSet1.zd);
            // TODO: 这行代码将数据加载到表“registerDataSet.register”中。您可以根据需要移动或删除它。
            this.registerTableAdapter.Fill(this.registerDataSet.register);

        }
        //候诊清屏
        private void button2_Click(object sender, EventArgs e)
        {

        }

        //EMR
        //EMR清屏
        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_zlk_e.Text = "";
            textBox_mz_e.Text = "";
            textBox_name_e.Text = "";
            textBox_age_e.Text = "";
            textBox_cid_e.Text = "";
            textBox_sex_e.Text = "";
            textBox_nat_e.Text = "";
            textBox_dep_e.Text = "";
            textBox_doc_e.Text = "";
            textBox_chas_e.Text = "";
            textBox_sr_e.Text = "";
            richTextBox_zs.Text = "";
            richTextBox_xbs.Text = "";
            richTextBox_jws.Text = "";

            textBox_mz_e.ReadOnly = false;
        }     
        //EMR模板   
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            
            if (this.treeView1.SelectedNode.Name == "主诉发热")
                richTextBox_zs.Text = "发热";
            else if (this.treeView1.SelectedNode.Name == "主诉腹痛")
                richTextBox_zs.Text =
                "[频率]腹痛<____>[时间单位]，[变化]伴[伴随症状](数值)<____> [时间单位] ";
            else if (this.treeView1.SelectedNode.Name == "现病发热")
                richTextBox_xbs.Text = "发热";
            else if (this.treeView1.SelectedNode.Name == "现病腹痛")
                richTextBox_xbs.Text = "患者于(数值)<____> [时间单位]前 " + "[诱因]" +  "出现[部位]" + "[频率]" +  "[腹痛性质]感，" +
                    "[频率]腹痛<____>[时间单位]，[变化]伴[伴随症状](数值)<____> [时间单位] ";
            else if (this.treeView1.SelectedNode.Name == "既往发热")
                richTextBox_jws.Text = "发热";
            else if (this.treeView1.SelectedNode.Name == "既往腹痛")
                richTextBox_jws.Text = "腹痛";

        }
        //EMR保存
        private void button_save_e_Click_1(object sender, EventArgs e)
        {

            DAL DB = new DAL();
            DB.ConnDB();

            Register.Register re = new Register.Register();
            re.zlk = textBox_zlk_e.Text;
            re.mz = textBox_mz_e.Text;
            re.name = textBox_name_e.Text;
            re.age = textBox_age_e.Text;
            re.sr = textBox_sr_e.Text;
            re.cid = textBox_cid_e.Text;
            re.nat = textBox_nat_e.Text;
            re.dep = textBox_dep_e.Text;
            re.doc = textBox_doc_e.Text;
            re.chas = textBox_chas_e.Text;
            re.zs = richTextBox_zs.Text;
            re.xbs = richTextBox_xbs.Text;
            re.jws = richTextBox_jws.Text;

            DB.insertERM(re);

            DB.TC();

            MessageBox.Show("保存成功！");

            DB.myconn.Close();
        }
        //EMR读取
        private void button_read_e_Click(object sender, EventArgs e)
        {        
                Register.Register re = new Register.Register();
                re.mz = textBox_mz_e.Text;


                DAL BD = new DAL();
                BD.ConnDB();


                BD.showEMR(re.mz, "mz");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    textBox_mz_e.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_mz_e.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("查无此病历，请重新输入");
                }

                BD.showEMR(re.mz, "zlk");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    textBox_zlk_e.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_zlk_e.ReadOnly = true;
                }

                BD.showEMR(re.mz, "name");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    textBox_name_e.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_name_e.ReadOnly = true;
                }

                BD.showEMR(re.mz, "age");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    textBox_age_e.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_age_e.ReadOnly = true;
                }

                BD.showEMR(re.mz, "sr");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    textBox_sr_e.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_sr_e.ReadOnly = true;
                }

                BD.showEMR(re.mz, "cid");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    textBox_cid_e.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_cid_e.ReadOnly = true;
                }

                BD.showEMR(re.mz, "sex");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    textBox_sex_e.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_sex_e.ReadOnly = true;
                }

                BD.showEMR(re.mz, "nat");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    textBox_nat_e.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_nat_e.ReadOnly = true;
                }

                BD.showEMR(re.mz, "dep");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    textBox_dep_e.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_dep_e.ReadOnly = true;
                }

                BD.showEMR(re.mz, "doc");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    textBox_doc_e.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_doc_e.ReadOnly = true;
                }

                BD.showEMR(re.mz, "chas");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    textBox_chas_e.Text = BD.mycmd.ExecuteScalar().ToString();
                    textBox_chas_e.ReadOnly = true;
                }

                BD.showEMR(re.mz, "xbs");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    richTextBox_xbs.Text = BD.mycmd.ExecuteScalar().ToString();
                    richTextBox_xbs.ReadOnly = true;
                }

                BD.showEMR(re.mz, "zs");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    richTextBox_zs.Text = BD.mycmd.ExecuteScalar().ToString();
                    richTextBox_zs.ReadOnly = true;
                }

                BD.showEMR(re.mz, "jws");
                if (BD.mycmd.ExecuteScalar() != null)
                {
                    richTextBox_jws.Text = BD.mycmd.ExecuteScalar().ToString();
                    richTextBox_jws.ReadOnly = true;
                }


            
        }

        //诊断
        //诊断保存
        private void button_zdsave_Click(object sender, EventArgs e)
        {
            DAL DB = new DAL();
            DB.ConnDB();

            Register.Register re = new Register.Register();
            //re.mz = textBox_mz_zd.Text;
            re.zlk = textBox_zlk_zd.Text;
            re.name = textBox_name_zd.Text;
            re.age = textBox_age_zd.Text;
            re.sex = textBox_sex_zd.Text;
            re.zds = comboBox_zds.Text;
            re.zdresult = comboBox_zdresult.Text;
            re.zdid = textBox_zdid.Text;
            re.fbdate = dateTimePicker_fb.Text;
            re.zddate = DateTime.Now.ToString();
            re.zdmain = checkBox_mainzd.CheckState.ToString();
            re.zdft = checkBox_ft.CheckState.ToString();
            re.zdconfirm = checkBox_confirm.CheckState.ToString();
            DB.insertZD(re);

            this.dataGridView_jz.DataMember = "";
            DB.GridviewZD(re.zlk);
            this.dataGridView_jz.DataSource = DB.dataset;
            this.dataGridView_jz.DataMember = "zd";

            DB.TC();

            MessageBox.Show("保存成功！");
            DB.delect(re.mz);

            DB.myconn.Close();
        }
        //诊断读取
        private void button_zdread_Click(object sender, EventArgs e)
        {
            Register.Register re = new Register.Register();
            re.zlk = textBox_zlk_zd.Text;

            DAL BD = new DAL();
            BD.ConnDB();

            BD.showZD(re.zlk, "zlk");
            if (BD.mycmd.ExecuteScalar() != null)
            {
                textBox_zlk_zd.Text = BD.mycmd.ExecuteScalar().ToString();
                textBox_zlk_zd.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("查无此病患，请重新输入");
            }

            BD.showZD(re.zlk, "name");
            if (BD.mycmd.ExecuteScalar() != null)
            {
                textBox_name_zd.Text = BD.mycmd.ExecuteScalar().ToString();
                textBox_name_zd.ReadOnly = true;
            }

            BD.showZD(re.zlk, "age");
            if (BD.mycmd.ExecuteScalar() != null)
            {
                textBox_age_zd.Text = BD.mycmd.ExecuteScalar().ToString();
                textBox_age_zd.ReadOnly = true;
            }

            BD.showZD(re.zlk, "sex");
            if (BD.mycmd.ExecuteScalar() != null)
            {
                textBox_sex_zd.Text = BD.mycmd.ExecuteScalar().ToString();
                textBox_sex_zd.ReadOnly = true;
            }
            BD.showZD(re.zlk, "zddate");
            if (BD.mycmd.ExecuteScalar() != null)
            {
                textBox_zddate.Text = BD.mycmd.ExecuteScalar().ToString();
                textBox_zddate.ReadOnly = true;
            }

            this.dataGridView_jz.DataMember = "";
            BD.GridviewZD(re.zlk);
            this.dataGridView_zd.DataSource = BD.dataset;
            this.dataGridView_zd.DataMember = "zd";

            //error
            BD.TC();
            BD.myconn.Close();
            MessageBox.Show("更新成功！");


        }
        
        //诊断清屏
        private void button_zdclear_Click(object sender, EventArgs e)
        {
            textBox_zlk_zd.Text = "";
            textBox_zlk_zd.ReadOnly = false;
            textBox_name_zd.Text = "";
            textBox_age_zd.Text = "";           
            textBox_sex_zd.Text = "";
            textBox_zdid.Text = "";
            comboBox_zdresult.Text = "";
            comboBox_zds.Text = "";
            dateTimePicker_ddate.Text = "";
            dateTimePicker_fb.Text = "";
            checkBox_confirm.CheckState = CheckState.Unchecked;
            checkBox_ft.CheckState = CheckState.Unchecked;
            checkBox_mainzd.CheckState = CheckState.Unchecked;          

        }
        //诊断帮助
        private void button_zdhelp_Click(object sender, EventArgs e)
        {

        }
        //获取诊断编码
        private void comboBox_zdresult_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = comboBox_zdresult.Text;
            DAL DB = new DAL();
            DB.ConnDB();
            DB.showICD10(result, "ICD10编码");
            try { textBox_zdid.Text = DB.mycmd.ExecuteScalar().ToString(); }
            catch { textBox_zdid.Text = "无此疾病ICD10编码"; }

        }

        private void textBox_zddate_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_zd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Register.Register re = new Register.Register();
            comboBox_zdresult.Text= this.dataGridView_jz.CurrentRow.Cells[1].Value.ToString();
            comboBox_zds.Text = this.dataGridView_jz.CurrentRow.Cells[0].Value.ToString();
            textBox_zdid.Text = this.dataGridView_jz.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker_fb.Text = this.dataGridView_jz.CurrentRow.Cells[3].Value.ToString();
            if (this.dataGridView_jz.CurrentRow.Cells[4].Value.ToString() == "Checked") checkBox_confirm.CheckState = CheckState.Checked;
            if (this.dataGridView_jz.CurrentRow.Cells[5].Value.ToString() == "Checked") checkBox_mainzd.CheckState = CheckState.Checked;
            if (this.dataGridView_jz.CurrentRow.Cells[6].Value.ToString() == "Checked") checkBox_ft.CheckState = CheckState.Checked;

        }
        //auto complete combtext according to input words 
        private void comboBox_zdresult_TextUpdate(object sender, EventArgs e)
        {
            string key = comboBox_zdresult.Text;
            DAL DB = new DAL();
            DB.ConnDB();
            DB.ComboxZD(key);
            DataTable dt = DB.dataset.Tables[0];
            this.autoComplete(dt, comboBox_zdresult,key, 2);
        }
        /*autoComplete 是实现combobox自动筛选填充的方法，根据cmb输入，筛选出包含改词的items
         * 输入 dbName,cmb,txt,column 分别为数据表名，cmb名，cmb内容，和数据表列号（从0开始）
         */
        public void autoComplete(DataTable dtCmbCompany, ComboBox cmb, string txt, int columnNum)
        {       
            string s;
            List<string> ListAll = new List<string>();
            List<string> ListSelect = new List<string>();

            for (int i = 0; i < dtCmbCompany.Rows.Count; i++)
            {
                s = dtCmbCompany.Rows[i][columnNum].ToString();
                ListAll.Add(s);
            }
            //选择数据
            cmb.Items.Clear();
            //清空listNew
            ListSelect.Clear();
            //遍历全部备查数据
            foreach (var item in ListAll)
            {
                if (item.Contains(txt))
                {
                    //符合，插入ListNew
                    ListSelect.Add(item);
                }
            }
            cmb.Items.AddRange(ListSelect.ToArray());
            cmb.SelectionStart = txt.Length;
            cmb.DroppedDown = true;
        }

        //show the alternative words 
        public static string  modekey;
        private void richTextBox_zs_Click(object sender, EventArgs e)
        {
            Modelist modelist = new Modelist();
            modekey = richTextBox_zs.SelectedText;
            if (modekey != ""&& modekey !=null) modelist.ShowDialog();
            if (modelist.DialogResult == DialogResult.OK)
                richTextBox_zs.SelectedText = modelist.modeword;           
        }

        private void richTextBox_xbs_Click_1(object sender, EventArgs e)
        {
            Modelist modelist = new Modelist();
            modekey = richTextBox_xbs.SelectedText;
            if (modekey != "" && modekey != null) modelist.ShowDialog();
            if (modelist.DialogResult == DialogResult.OK)
                richTextBox_xbs.SelectedText = modelist.modeword;
        }
    }
}
