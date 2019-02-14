using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorSta
{
    public partial class Modelist : Form
    {
        public Modelist()
        {
            InitializeComponent();
        }
        //alternative words setting 
        private void Modelist_Load(object sender, EventArgs e)
        {
            string[] frequence = { "阵发性", "反复", "频发", "突发", "持续性", "偶发", "间断性 " };
            string[] time = { "年","月","周","天","小时","分钟" };
            string[] change = { "加重","恶化","减轻" };
            string[] ssymptom = { "发热","寒战","黄疸","呕吐","反酸","嗳气","腹泻","血尿","尿频","尿急","肛门停止排便排气" };
            string[] cause = { "无明显诱因","劳累后","餐后","情绪激动后","天气变化后","进食油腻食物后","酗酒后","暴饮暴食后" };
            string[] position = {"右上","中上","左上","上","脐周","右中","左中","右下","下","左下","弥漫性","游走性"};
            switch (DUI.modekey)
            {
                case "[频率]": addlist(frequence); break;
                case "[时间单位]": addlist(time); break;
                case "[变化]": addlist(change); break;
                case "[伴随症状]": addlist(ssymptom); break;
                case "[诱因]": addlist(cause); break;
                case "[部位]": addlist(position); break;
            }         
        }
        public  string modeword { get ; set; }
        private void cblist_SelectedIndexChanged(object sender, EventArgs e)
        {
            modeword = cblist.Text;
            this.DialogResult = DialogResult.OK;
        }
        private void addlist(string[] list)
        {
            for (int i = 0; i < list.Length; i++)
                cblist.Items.Add(list[i]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
