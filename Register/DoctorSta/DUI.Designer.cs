namespace DoctorSta
{
    partial class DUI
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DUI));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("发热");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("腹痛");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("主诉模板", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("发热");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("腹痛");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("现病史模板", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("发热");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("腹痛");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("既往史模板", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("色素沉着,水肿,多发性神经病综合征");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("费舍综合征(变异型格林-巴利综合征)");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("感染后多发性周围神经病");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("常用诊断", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_doc = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePicker_ddate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox_dtime = new System.Windows.Forms.ComboBox();
            this.panel_jz = new System.Windows.Forms.Panel();
            this.dataGridView_jz = new System.Windows.Forms.DataGridView();
            this.mzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zlkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerDataSet = new DoctorSta.registerDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_read = new System.Windows.Forms.Button();
            this.button_jz = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_read_e = new System.Windows.Forms.Button();
            this.textBox_chas_e = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_cid_e = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_nat_e = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_sr_e = new System.Windows.Forms.TextBox();
            this.textBox_age_e = new System.Windows.Forms.TextBox();
            this.textBox_sex_e = new System.Windows.Forms.TextBox();
            this.textBox_name_e = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_doc_e = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_dep_e = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_mz_e = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_zlk_e = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            this.button_save_e = new System.Windows.Forms.Button();
            this.panel_emr = new System.Windows.Forms.Panel();
            this.richTextBox_jws = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.richTextBox_xbs = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.richTextBox_zs = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_zd = new System.Windows.Forms.DataGridView();
            this.zds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdresultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fbdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdmainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdconfirmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerDataSet1 = new DoctorSta.registerDataSet1();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox_confirm = new System.Windows.Forms.CheckBox();
            this.checkBox_mainzd = new System.Windows.Forms.CheckBox();
            this.checkBox_ft = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_fb = new System.Windows.Forms.DateTimePicker();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox_zdid = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.comboBox_zdresult = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.comboBox_zds = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox_age_zd = new System.Windows.Forms.TextBox();
            this.textBox_sex_zd = new System.Windows.Forms.TextBox();
            this.textBox_name_zd = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox_zlk_zd = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox_zddate = new System.Windows.Forms.TextBox();
            this.button_zdhelp = new System.Windows.Forms.Button();
            this.button_zdread = new System.Windows.Forms.Button();
            this.button_zdclear = new System.Windows.Forms.Button();
            this.button_zdsave = new System.Windows.Forms.Button();
            this.registerTableAdapter = new DoctorSta.registerDataSetTableAdapters.registerTableAdapter();
            this.zdTableAdapter = new DoctorSta.registerDataSet1TableAdapters.zdTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel_jz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_jz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel_emr.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_zd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.textBox_doc);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.dateTimePicker_ddate);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.comboBox_dtime);
            this.tabPage1.Controls.Add(this.panel_jz);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button_read);
            this.tabPage1.Controls.Add(this.button_jz);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(825, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "患者";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(216, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 22;
            this.label19.Text = "医生：";
            // 
            // textBox_doc
            // 
            this.textBox_doc.Enabled = false;
            this.textBox_doc.Location = new System.Drawing.Point(269, 14);
            this.textBox_doc.Name = "textBox_doc";
            this.textBox_doc.Size = new System.Drawing.Size(100, 21);
            this.textBox_doc.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(375, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 20;
            this.label18.Text = "日期：";
            // 
            // dateTimePicker_ddate
            // 
            this.dateTimePicker_ddate.Location = new System.Drawing.Point(422, 14);
            this.dateTimePicker_ddate.Name = "dateTimePicker_ddate";
            this.dateTimePicker_ddate.Size = new System.Drawing.Size(121, 21);
            this.dateTimePicker_ddate.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(549, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 18;
            this.label17.Text = "午别：";
            // 
            // comboBox_dtime
            // 
            this.comboBox_dtime.FormattingEnabled = true;
            this.comboBox_dtime.Items.AddRange(new object[] {
            "上午",
            "中午",
            "下午",
            "晚间"});
            this.comboBox_dtime.Location = new System.Drawing.Point(596, 14);
            this.comboBox_dtime.Name = "comboBox_dtime";
            this.comboBox_dtime.Size = new System.Drawing.Size(63, 20);
            this.comboBox_dtime.TabIndex = 17;
            // 
            // panel_jz
            // 
            this.panel_jz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_jz.Controls.Add(this.dataGridView_jz);
            this.panel_jz.Controls.Add(this.label1);
            this.panel_jz.Location = new System.Drawing.Point(0, 48);
            this.panel_jz.Name = "panel_jz";
            this.panel_jz.Size = new System.Drawing.Size(814, 452);
            this.panel_jz.TabIndex = 14;
            // 
            // dataGridView_jz
            // 
            this.dataGridView_jz.AutoGenerateColumns = false;
            this.dataGridView_jz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_jz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_jz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mzDataGridViewTextBoxColumn,
            this.zlkDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.srDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.natDataGridViewTextBoxColumn,
            this.depDataGridViewTextBoxColumn,
            this.docDataGridViewTextBoxColumn});
            this.dataGridView_jz.DataSource = this.registerBindingSource;
            this.dataGridView_jz.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_jz.Location = new System.Drawing.Point(0, 57);
            this.dataGridView_jz.Name = "dataGridView_jz";
            this.dataGridView_jz.RowTemplate.Height = 23;
            this.dataGridView_jz.Size = new System.Drawing.Size(810, 391);
            this.dataGridView_jz.TabIndex = 16;
            // 
            // mzDataGridViewTextBoxColumn
            // 
            this.mzDataGridViewTextBoxColumn.DataPropertyName = "mz";
            this.mzDataGridViewTextBoxColumn.HeaderText = "门诊号";
            this.mzDataGridViewTextBoxColumn.Name = "mzDataGridViewTextBoxColumn";
            // 
            // zlkDataGridViewTextBoxColumn
            // 
            this.zlkDataGridViewTextBoxColumn.DataPropertyName = "zlk";
            this.zlkDataGridViewTextBoxColumn.HeaderText = "诊疗卡";
            this.zlkDataGridViewTextBoxColumn.Name = "zlkDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "年龄";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // srDataGridViewTextBoxColumn
            // 
            this.srDataGridViewTextBoxColumn.DataPropertyName = "sr";
            this.srDataGridViewTextBoxColumn.HeaderText = "生日";
            this.srDataGridViewTextBoxColumn.Name = "srDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "性别";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // natDataGridViewTextBoxColumn
            // 
            this.natDataGridViewTextBoxColumn.DataPropertyName = "nat";
            this.natDataGridViewTextBoxColumn.HeaderText = "民族";
            this.natDataGridViewTextBoxColumn.Name = "natDataGridViewTextBoxColumn";
            // 
            // depDataGridViewTextBoxColumn
            // 
            this.depDataGridViewTextBoxColumn.DataPropertyName = "dep";
            this.depDataGridViewTextBoxColumn.HeaderText = "科室";
            this.depDataGridViewTextBoxColumn.Name = "depDataGridViewTextBoxColumn";
            // 
            // docDataGridViewTextBoxColumn
            // 
            this.docDataGridViewTextBoxColumn.DataPropertyName = "doc";
            this.docDataGridViewTextBoxColumn.HeaderText = "医生";
            this.docDataGridViewTextBoxColumn.Name = "docDataGridViewTextBoxColumn";
            // 
            // registerBindingSource
            // 
            this.registerBindingSource.DataMember = "register";
            this.registerBindingSource.DataSource = this.registerDataSet;
            // 
            // registerDataSet
            // 
            this.registerDataSet.DataSetName = "registerDataSet";
            this.registerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(819, 54);
            this.label1.TabIndex = 15;
            this.label1.Text = "候诊情况";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(739, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "帮助";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(665, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "清屏";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_read
            // 
            this.button_read.FlatAppearance.BorderSize = 0;
            this.button_read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_read.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_read.Image = ((System.Drawing.Image)(resources.GetObject("button_read.Image")));
            this.button_read.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_read.Location = new System.Drawing.Point(86, 6);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(109, 36);
            this.button_read.TabIndex = 11;
            this.button_read.Text = "刷新";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // button_jz
            // 
            this.button_jz.FlatAppearance.BorderSize = 0;
            this.button_jz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_jz.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_jz.Image = ((System.Drawing.Image)(resources.GetObject("button_jz.Image")));
            this.button_jz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_jz.Location = new System.Drawing.Point(5, 6);
            this.button_jz.Name = "button_jz";
            this.button_jz.Size = new System.Drawing.Size(75, 36);
            this.button_jz.TabIndex = 10;
            this.button_jz.Text = "接诊";
            this.button_jz.UseVisualStyleBackColor = true;
            this.button_jz.Click += new System.EventHandler(this.button_jz_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_read_e);
            this.tabPage2.Controls.Add(this.textBox_chas_e);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.textBox_cid_e);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBox_nat_e);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBox_sr_e);
            this.tabPage2.Controls.Add(this.textBox_age_e);
            this.tabPage2.Controls.Add(this.textBox_sex_e);
            this.tabPage2.Controls.Add(this.textBox_name_e);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox_doc_e);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox_dep_e);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox_mz_e);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBox_zlk_e);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button_clear);
            this.tabPage2.Controls.Add(this.button_help);
            this.tabPage2.Controls.Add(this.button_save_e);
            this.tabPage2.Controls.Add(this.panel_emr);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(825, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "电子病历";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_read_e
            // 
            this.button_read_e.FlatAppearance.BorderSize = 0;
            this.button_read_e.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_read_e.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_read_e.Image = ((System.Drawing.Image)(resources.GetObject("button_read_e.Image")));
            this.button_read_e.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_read_e.Location = new System.Drawing.Point(81, 0);
            this.button_read_e.Name = "button_read_e";
            this.button_read_e.Size = new System.Drawing.Size(109, 36);
            this.button_read_e.TabIndex = 31;
            this.button_read_e.Text = "读取病历";
            this.button_read_e.UseVisualStyleBackColor = true;
            this.button_read_e.Click += new System.EventHandler(this.button_read_e_Click);
            // 
            // textBox_chas_e
            // 
            this.textBox_chas_e.Location = new System.Drawing.Point(776, 38);
            this.textBox_chas_e.Name = "textBox_chas_e";
            this.textBox_chas_e.Size = new System.Drawing.Size(43, 21);
            this.textBox_chas_e.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(749, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 29;
            this.label12.Text = "费别";
            // 
            // textBox_cid_e
            // 
            this.textBox_cid_e.Location = new System.Drawing.Point(659, 65);
            this.textBox_cid_e.Name = "textBox_cid_e";
            this.textBox_cid_e.Size = new System.Drawing.Size(160, 21);
            this.textBox_cid_e.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(600, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 27;
            this.label11.Text = "身份证号";
            // 
            // textBox_nat_e
            // 
            this.textBox_nat_e.Location = new System.Drawing.Point(551, 66);
            this.textBox_nat_e.Name = "textBox_nat_e";
            this.textBox_nat_e.Size = new System.Drawing.Size(43, 21);
            this.textBox_nat_e.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(517, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "民族";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 24;
            this.label9.Text = "生日";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "年龄";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "性别";
            // 
            // textBox_sr_e
            // 
            this.textBox_sr_e.Location = new System.Drawing.Point(380, 66);
            this.textBox_sr_e.Name = "textBox_sr_e";
            this.textBox_sr_e.Size = new System.Drawing.Size(131, 21);
            this.textBox_sr_e.TabIndex = 15;
            // 
            // textBox_age_e
            // 
            this.textBox_age_e.Location = new System.Drawing.Point(293, 66);
            this.textBox_age_e.Name = "textBox_age_e";
            this.textBox_age_e.Size = new System.Drawing.Size(46, 21);
            this.textBox_age_e.TabIndex = 22;
            // 
            // textBox_sex_e
            // 
            this.textBox_sex_e.Location = new System.Drawing.Point(209, 67);
            this.textBox_sex_e.Name = "textBox_sex_e";
            this.textBox_sex_e.Size = new System.Drawing.Size(43, 21);
            this.textBox_sex_e.TabIndex = 21;
            // 
            // textBox_name_e
            // 
            this.textBox_name_e.Location = new System.Drawing.Point(40, 65);
            this.textBox_name_e.Name = "textBox_name_e";
            this.textBox_name_e.Size = new System.Drawing.Size(132, 21);
            this.textBox_name_e.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "姓名";
            // 
            // textBox_doc_e
            // 
            this.textBox_doc_e.Location = new System.Drawing.Point(660, 38);
            this.textBox_doc_e.Name = "textBox_doc_e";
            this.textBox_doc_e.Size = new System.Drawing.Size(83, 21);
            this.textBox_doc_e.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "医生";
            // 
            // textBox_dep_e
            // 
            this.textBox_dep_e.Location = new System.Drawing.Point(519, 36);
            this.textBox_dep_e.Name = "textBox_dep_e";
            this.textBox_dep_e.Size = new System.Drawing.Size(100, 21);
            this.textBox_dep_e.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "科室";
            // 
            // textBox_mz_e
            // 
            this.textBox_mz_e.Location = new System.Drawing.Point(50, 36);
            this.textBox_mz_e.Name = "textBox_mz_e";
            this.textBox_mz_e.Size = new System.Drawing.Size(177, 21);
            this.textBox_mz_e.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "门诊号";
            // 
            // textBox_zlk_e
            // 
            this.textBox_zlk_e.Location = new System.Drawing.Point(301, 36);
            this.textBox_zlk_e.Name = "textBox_zlk_e";
            this.textBox_zlk_e.Size = new System.Drawing.Size(177, 21);
            this.textBox_zlk_e.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "诊疗卡号";
            // 
            // button_clear
            // 
            this.button_clear.FlatAppearance.BorderSize = 0;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_clear.Image = ((System.Drawing.Image)(resources.GetObject("button_clear.Image")));
            this.button_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_clear.Location = new System.Drawing.Point(658, 2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 36);
            this.button_clear.TabIndex = 12;
            this.button_clear.Text = "清屏";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_help
            // 
            this.button_help.FlatAppearance.BorderSize = 0;
            this.button_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_help.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_help.Image = ((System.Drawing.Image)(resources.GetObject("button_help.Image")));
            this.button_help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_help.Location = new System.Drawing.Point(747, 0);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(75, 36);
            this.button_help.TabIndex = 13;
            this.button_help.Text = "帮助";
            this.button_help.UseVisualStyleBackColor = true;
            // 
            // button_save_e
            // 
            this.button_save_e.FlatAppearance.BorderSize = 0;
            this.button_save_e.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save_e.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_save_e.Image = ((System.Drawing.Image)(resources.GetObject("button_save_e.Image")));
            this.button_save_e.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_save_e.Location = new System.Drawing.Point(0, 0);
            this.button_save_e.Name = "button_save_e";
            this.button_save_e.Size = new System.Drawing.Size(75, 36);
            this.button_save_e.TabIndex = 10;
            this.button_save_e.Text = "保存";
            this.button_save_e.UseVisualStyleBackColor = true;
            this.button_save_e.Click += new System.EventHandler(this.button_save_e_Click_1);
            // 
            // panel_emr
            // 
            this.panel_emr.AutoScroll = true;
            this.panel_emr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_emr.Controls.Add(this.richTextBox_jws);
            this.panel_emr.Controls.Add(this.label16);
            this.panel_emr.Controls.Add(this.richTextBox_xbs);
            this.panel_emr.Controls.Add(this.label15);
            this.panel_emr.Controls.Add(this.richTextBox_zs);
            this.panel_emr.Controls.Add(this.label14);
            this.panel_emr.Controls.Add(this.label13);
            this.panel_emr.Controls.Add(this.treeView1);
            this.panel_emr.Location = new System.Drawing.Point(6, 105);
            this.panel_emr.Name = "panel_emr";
            this.panel_emr.Size = new System.Drawing.Size(817, 427);
            this.panel_emr.TabIndex = 0;
            // 
            // richTextBox_jws
            // 
            this.richTextBox_jws.Location = new System.Drawing.Point(125, 464);
            this.richTextBox_jws.Name = "richTextBox_jws";
            this.richTextBox_jws.Size = new System.Drawing.Size(660, 180);
            this.richTextBox_jws.TabIndex = 7;
            this.richTextBox_jws.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(126, 449);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 6;
            this.label16.Text = "既往史";
            // 
            // richTextBox_xbs
            // 
            this.richTextBox_xbs.Location = new System.Drawing.Point(128, 260);
            this.richTextBox_xbs.Name = "richTextBox_xbs";
            this.richTextBox_xbs.Size = new System.Drawing.Size(660, 180);
            this.richTextBox_xbs.TabIndex = 5;
            this.richTextBox_xbs.Text = "";
            this.richTextBox_xbs.Click += new System.EventHandler(this.richTextBox_xbs_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(126, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 4;
            this.label15.Text = "现病史";
            // 
            // richTextBox_zs
            // 
            this.richTextBox_zs.Location = new System.Drawing.Point(130, 61);
            this.richTextBox_zs.Name = "richTextBox_zs";
            this.richTextBox_zs.Size = new System.Drawing.Size(660, 181);
            this.richTextBox_zs.TabIndex = 3;
            this.richTextBox_zs.Text = "";
            this.richTextBox_zs.Click += new System.EventHandler(this.richTextBox_zs_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(134, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "主诉";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(136, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(649, 40);
            this.label13.TabIndex = 1;
            this.label13.Text = "电子病历";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "主诉发热";
            treeNode1.Text = "发热";
            treeNode2.Name = "主诉腹痛";
            treeNode2.Text = "腹痛";
            treeNode3.Name = "节点0";
            treeNode3.Text = "主诉模板";
            treeNode4.Name = "现病发热";
            treeNode4.Text = "发热";
            treeNode5.Name = "现病腹痛";
            treeNode5.Text = "腹痛";
            treeNode6.Name = "节点1";
            treeNode6.Text = "现病史模板";
            treeNode7.Name = "既往发热";
            treeNode7.Text = "发热";
            treeNode8.Name = "既往腹痛";
            treeNode8.Text = "腹痛";
            treeNode9.Name = "既往史模板";
            treeNode9.Text = "既往史模板";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(121, 651);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.button_zdhelp);
            this.tabPage3.Controls.Add(this.button_zdread);
            this.tabPage3.Controls.Add(this.button_zdclear);
            this.tabPage3.Controls.Add(this.button_zdsave);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(825, 535);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "诊断";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dataGridView_zd);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dateTimePicker_fb);
            this.panel3.Controls.Add(this.label34);
            this.panel3.Controls.Add(this.textBox_zdid);
            this.panel3.Controls.Add(this.label33);
            this.panel3.Controls.Add(this.comboBox_zdresult);
            this.panel3.Controls.Add(this.label32);
            this.panel3.Controls.Add(this.comboBox_zds);
            this.panel3.Controls.Add(this.label31);
            this.panel3.Location = new System.Drawing.Point(169, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(656, 396);
            this.panel3.TabIndex = 38;
            // 
            // dataGridView_zd
            // 
            this.dataGridView_zd.AutoGenerateColumns = false;
            this.dataGridView_zd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_zd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_zd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zds,
            this.zdresultDataGridViewTextBoxColumn,
            this.zdidDataGridViewTextBoxColumn,
            this.fbdateDataGridViewTextBoxColumn,
            this.zddateDataGridViewTextBoxColumn,
            this.zdmainDataGridViewTextBoxColumn,
            this.zdftDataGridViewTextBoxColumn,
            this.zdconfirmDataGridViewTextBoxColumn});
            this.dataGridView_zd.DataSource = this.zdBindingSource;
            this.dataGridView_zd.Enabled = false;
            this.dataGridView_zd.Location = new System.Drawing.Point(6, 76);
            this.dataGridView_zd.Name = "dataGridView_zd";
            this.dataGridView_zd.RowTemplate.Height = 23;
            this.dataGridView_zd.Size = new System.Drawing.Size(640, 313);
            this.dataGridView_zd.TabIndex = 13;
            this.dataGridView_zd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_zd_CellContentClick);
            // 
            // zds
            // 
            this.zds.DataPropertyName = "zds";
            this.zds.HeaderText = "诊断分类";
            this.zds.Name = "zds";
            this.zds.Visible = false;
            // 
            // zdresultDataGridViewTextBoxColumn
            // 
            this.zdresultDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.zdresultDataGridViewTextBoxColumn.DataPropertyName = "zdresult";
            this.zdresultDataGridViewTextBoxColumn.HeaderText = "诊断结果";
            this.zdresultDataGridViewTextBoxColumn.Name = "zdresultDataGridViewTextBoxColumn";
            // 
            // zdidDataGridViewTextBoxColumn
            // 
            this.zdidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.zdidDataGridViewTextBoxColumn.DataPropertyName = "zdid";
            this.zdidDataGridViewTextBoxColumn.HeaderText = "诊断编码";
            this.zdidDataGridViewTextBoxColumn.Name = "zdidDataGridViewTextBoxColumn";
            this.zdidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fbdateDataGridViewTextBoxColumn
            // 
            this.fbdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fbdateDataGridViewTextBoxColumn.DataPropertyName = "fbdate";
            this.fbdateDataGridViewTextBoxColumn.HeaderText = "发病日期";
            this.fbdateDataGridViewTextBoxColumn.Name = "fbdateDataGridViewTextBoxColumn";
            // 
            // zddateDataGridViewTextBoxColumn
            // 
            this.zddateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.zddateDataGridViewTextBoxColumn.DataPropertyName = "zddate";
            this.zddateDataGridViewTextBoxColumn.HeaderText = "诊断日期";
            this.zddateDataGridViewTextBoxColumn.Name = "zddateDataGridViewTextBoxColumn";
            // 
            // zdmainDataGridViewTextBoxColumn
            // 
            this.zdmainDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.zdmainDataGridViewTextBoxColumn.DataPropertyName = "zdmain";
            this.zdmainDataGridViewTextBoxColumn.HeaderText = "主要诊断";
            this.zdmainDataGridViewTextBoxColumn.Name = "zdmainDataGridViewTextBoxColumn";
            // 
            // zdftDataGridViewTextBoxColumn
            // 
            this.zdftDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.zdftDataGridViewTextBoxColumn.DataPropertyName = "zdft";
            this.zdftDataGridViewTextBoxColumn.HeaderText = "首诊";
            this.zdftDataGridViewTextBoxColumn.Name = "zdftDataGridViewTextBoxColumn";
            // 
            // zdconfirmDataGridViewTextBoxColumn
            // 
            this.zdconfirmDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.zdconfirmDataGridViewTextBoxColumn.DataPropertyName = "zdconfirm";
            this.zdconfirmDataGridViewTextBoxColumn.HeaderText = "确诊";
            this.zdconfirmDataGridViewTextBoxColumn.Name = "zdconfirmDataGridViewTextBoxColumn";
            // 
            // zdBindingSource
            // 
            this.zdBindingSource.DataMember = "zd";
            this.zdBindingSource.DataSource = this.registerDataSet1;
            // 
            // registerDataSet1
            // 
            this.registerDataSet1.DataSetName = "registerDataSet1";
            this.registerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.checkBox_confirm);
            this.panel4.Controls.Add(this.checkBox_mainzd);
            this.panel4.Controls.Add(this.checkBox_ft);
            this.panel4.Location = new System.Drawing.Point(281, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 21);
            this.panel4.TabIndex = 12;
            // 
            // checkBox_confirm
            // 
            this.checkBox_confirm.AutoSize = true;
            this.checkBox_confirm.Location = new System.Drawing.Point(31, 3);
            this.checkBox_confirm.Name = "checkBox_confirm";
            this.checkBox_confirm.Size = new System.Drawing.Size(48, 16);
            this.checkBox_confirm.TabIndex = 11;
            this.checkBox_confirm.Text = "确诊";
            this.checkBox_confirm.UseVisualStyleBackColor = true;
            // 
            // checkBox_mainzd
            // 
            this.checkBox_mainzd.AutoSize = true;
            this.checkBox_mainzd.Location = new System.Drawing.Point(114, 3);
            this.checkBox_mainzd.Name = "checkBox_mainzd";
            this.checkBox_mainzd.Size = new System.Drawing.Size(72, 16);
            this.checkBox_mainzd.TabIndex = 3;
            this.checkBox_mainzd.Text = "主要诊断";
            this.checkBox_mainzd.UseVisualStyleBackColor = true;
            // 
            // checkBox_ft
            // 
            this.checkBox_ft.AutoSize = true;
            this.checkBox_ft.Location = new System.Drawing.Point(235, 3);
            this.checkBox_ft.Name = "checkBox_ft";
            this.checkBox_ft.Size = new System.Drawing.Size(48, 16);
            this.checkBox_ft.TabIndex = 4;
            this.checkBox_ft.Text = "首诊";
            this.checkBox_ft.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_fb
            // 
            this.dateTimePicker_fb.Location = new System.Drawing.Point(80, 49);
            this.dateTimePicker_fb.Name = "dateTimePicker_fb";
            this.dateTimePicker_fb.Size = new System.Drawing.Size(181, 21);
            this.dateTimePicker_fb.TabIndex = 10;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(9, 54);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(65, 12);
            this.label34.TabIndex = 9;
            this.label34.Text = "发病日期：";
            // 
            // textBox_zdid
            // 
            this.textBox_zdid.Location = new System.Drawing.Point(543, 15);
            this.textBox_zdid.Name = "textBox_zdid";
            this.textBox_zdid.Size = new System.Drawing.Size(100, 21);
            this.textBox_zdid.TabIndex = 8;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(472, 19);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(65, 12);
            this.label33.TabIndex = 7;
            this.label33.Text = "诊断编码：";
            // 
            // comboBox_zdresult
            // 
            this.comboBox_zdresult.FormattingEnabled = true;
            this.comboBox_zdresult.Location = new System.Drawing.Point(237, 15);
            this.comboBox_zdresult.Name = "comboBox_zdresult";
            this.comboBox_zdresult.Size = new System.Drawing.Size(231, 20);
            this.comboBox_zdresult.TabIndex = 6;
            this.comboBox_zdresult.SelectedIndexChanged += new System.EventHandler(this.comboBox_zdresult_SelectedIndexChanged);
            this.comboBox_zdresult.TextUpdate += new System.EventHandler(this.comboBox_zdresult_TextUpdate);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(178, 18);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(65, 12);
            this.label32.TabIndex = 5;
            this.label32.Text = "诊断结果：";
            // 
            // comboBox_zds
            // 
            this.comboBox_zds.FormattingEnabled = true;
            this.comboBox_zds.Items.AddRange(new object[] {
            "中医诊断",
            "西医诊断"});
            this.comboBox_zds.Location = new System.Drawing.Point(80, 16);
            this.comboBox_zds.Name = "comboBox_zds";
            this.comboBox_zds.Size = new System.Drawing.Size(94, 20);
            this.comboBox_zds.TabIndex = 1;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(9, 19);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(65, 12);
            this.label31.TabIndex = 0;
            this.label31.Text = "诊断分类：";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.treeView2);
            this.panel2.Location = new System.Drawing.Point(6, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 398);
            this.panel2.TabIndex = 37;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(0, 0);
            this.treeView2.Name = "treeView2";
            treeNode10.Name = "色素沉着,水肿,多发性神经病综合征";
            treeNode10.Text = "色素沉着,水肿,多发性神经病综合征";
            treeNode11.Name = "节点2";
            treeNode11.Text = "费舍综合征(变异型格林-巴利综合征)";
            treeNode12.Name = "节点3";
            treeNode12.Text = "感染后多发性周围神经病";
            treeNode13.Name = "节点0";
            treeNode13.Text = "常用诊断";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.treeView2.Size = new System.Drawing.Size(153, 391);
            this.treeView2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.textBox_age_zd);
            this.panel1.Controls.Add(this.textBox_sex_zd);
            this.panel1.Controls.Add(this.textBox_name_zd);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.textBox_zlk_zd);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.textBox_zddate);
            this.panel1.Location = new System.Drawing.Point(3, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 67);
            this.panel1.TabIndex = 36;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(507, 13);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 12);
            this.label24.TabIndex = 38;
            this.label24.Text = "年龄";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(423, 13);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 12);
            this.label25.TabIndex = 45;
            this.label25.Text = "性别";
            // 
            // textBox_age_zd
            // 
            this.textBox_age_zd.Location = new System.Drawing.Point(542, 9);
            this.textBox_age_zd.Name = "textBox_age_zd";
            this.textBox_age_zd.Size = new System.Drawing.Size(46, 21);
            this.textBox_age_zd.TabIndex = 44;
            // 
            // textBox_sex_zd
            // 
            this.textBox_sex_zd.Location = new System.Drawing.Point(458, 10);
            this.textBox_sex_zd.Name = "textBox_sex_zd";
            this.textBox_sex_zd.Size = new System.Drawing.Size(43, 21);
            this.textBox_sex_zd.TabIndex = 43;
            // 
            // textBox_name_zd
            // 
            this.textBox_name_zd.Location = new System.Drawing.Point(289, 8);
            this.textBox_name_zd.Name = "textBox_name_zd";
            this.textBox_name_zd.Size = new System.Drawing.Size(132, 21);
            this.textBox_name_zd.TabIndex = 42;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(254, 11);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 12);
            this.label26.TabIndex = 32;
            this.label26.Text = "姓名";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(594, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 46;
            this.label23.Text = "诊断日期";
            // 
            // textBox_zlk_zd
            // 
            this.textBox_zlk_zd.Location = new System.Drawing.Point(63, 9);
            this.textBox_zlk_zd.Name = "textBox_zlk_zd";
            this.textBox_zlk_zd.Size = new System.Drawing.Size(177, 21);
            this.textBox_zlk_zd.TabIndex = 34;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(4, 12);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 12);
            this.label30.TabIndex = 33;
            this.label30.Text = "诊疗卡号";
            // 
            // textBox_zddate
            // 
            this.textBox_zddate.Location = new System.Drawing.Point(653, 9);
            this.textBox_zddate.Name = "textBox_zddate";
            this.textBox_zddate.Size = new System.Drawing.Size(131, 21);
            this.textBox_zddate.TabIndex = 36;
            this.textBox_zddate.TextChanged += new System.EventHandler(this.textBox_zddate_TextChanged);
            // 
            // button_zdhelp
            // 
            this.button_zdhelp.FlatAppearance.BorderSize = 0;
            this.button_zdhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zdhelp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_zdhelp.Image = ((System.Drawing.Image)(resources.GetObject("button_zdhelp.Image")));
            this.button_zdhelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_zdhelp.Location = new System.Drawing.Point(747, 6);
            this.button_zdhelp.Name = "button_zdhelp";
            this.button_zdhelp.Size = new System.Drawing.Size(75, 36);
            this.button_zdhelp.TabIndex = 35;
            this.button_zdhelp.Text = "帮助";
            this.button_zdhelp.UseVisualStyleBackColor = true;
            this.button_zdhelp.Click += new System.EventHandler(this.button_zdhelp_Click);
            // 
            // button_zdread
            // 
            this.button_zdread.FlatAppearance.BorderSize = 0;
            this.button_zdread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zdread.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_zdread.Image = ((System.Drawing.Image)(resources.GetObject("button_zdread.Image")));
            this.button_zdread.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_zdread.Location = new System.Drawing.Point(81, 6);
            this.button_zdread.Name = "button_zdread";
            this.button_zdread.Size = new System.Drawing.Size(109, 36);
            this.button_zdread.TabIndex = 34;
            this.button_zdread.Text = "读取诊断";
            this.button_zdread.UseVisualStyleBackColor = true;
            this.button_zdread.Click += new System.EventHandler(this.button_zdread_Click);
            // 
            // button_zdclear
            // 
            this.button_zdclear.FlatAppearance.BorderSize = 0;
            this.button_zdclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zdclear.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_zdclear.Image = ((System.Drawing.Image)(resources.GetObject("button_zdclear.Image")));
            this.button_zdclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_zdclear.Location = new System.Drawing.Point(658, 6);
            this.button_zdclear.Name = "button_zdclear";
            this.button_zdclear.Size = new System.Drawing.Size(75, 36);
            this.button_zdclear.TabIndex = 33;
            this.button_zdclear.Text = "清屏";
            this.button_zdclear.UseVisualStyleBackColor = true;
            this.button_zdclear.Click += new System.EventHandler(this.button_zdclear_Click);
            // 
            // button_zdsave
            // 
            this.button_zdsave.FlatAppearance.BorderSize = 0;
            this.button_zdsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zdsave.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_zdsave.Image = ((System.Drawing.Image)(resources.GetObject("button_zdsave.Image")));
            this.button_zdsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_zdsave.Location = new System.Drawing.Point(0, 6);
            this.button_zdsave.Name = "button_zdsave";
            this.button_zdsave.Size = new System.Drawing.Size(75, 36);
            this.button_zdsave.TabIndex = 32;
            this.button_zdsave.Text = "保存";
            this.button_zdsave.UseVisualStyleBackColor = true;
            this.button_zdsave.Click += new System.EventHandler(this.button_zdsave_Click);
            // 
            // registerTableAdapter
            // 
            this.registerTableAdapter.ClearBeforeFill = true;
            // 
            // zdTableAdapter
            // 
            this.zdTableAdapter.ClearBeforeFill = true;
            // 
            // DUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 561);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DUI";
            this.Text = "医生工作站";
            this.Load += new System.EventHandler(this.DUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel_jz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_jz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel_emr.ResumeLayout(false);
            this.panel_emr.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_zd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel_emr;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.Button button_save_e;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.Button button_jz;
        private System.Windows.Forms.Panel panel_jz;
        private System.Windows.Forms.DataGridView dataGridView_jz;
        private System.Windows.Forms.Label label1;
        private registerDataSet registerDataSet;
        private System.Windows.Forms.BindingSource registerBindingSource;
        private registerDataSetTableAdapters.registerTableAdapter registerTableAdapter;
        private System.Windows.Forms.TextBox textBox_sr_e;
        private System.Windows.Forms.TextBox textBox_age_e;
        private System.Windows.Forms.TextBox textBox_sex_e;
        private System.Windows.Forms.TextBox textBox_name_e;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_doc_e;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_dep_e;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_mz_e;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_zlk_e;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_chas_e;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_cid_e;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_nat_e;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox_xbs;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox richTextBox_zs;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox richTextBox_jws;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button_read_e;
        private System.Windows.Forms.ComboBox comboBox_dtime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ddate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zlkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn natDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button_zdhelp;
        private System.Windows.Forms.Button button_zdread;
        private System.Windows.Forms.Button button_zdclear;
        private System.Windows.Forms.Button button_zdsave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox_zddate;
        private System.Windows.Forms.TextBox textBox_age_zd;
        private System.Windows.Forms.TextBox textBox_sex_zd;
        private System.Windows.Forms.TextBox textBox_name_zd;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox_zlk_zd;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.CheckBox checkBox_mainzd;
        private System.Windows.Forms.ComboBox comboBox_zds;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox checkBox_confirm;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fb;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBox_zdid;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox comboBox_zdresult;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.CheckBox checkBox_ft;
        private System.Windows.Forms.DataGridView dataGridView_zd;
        private registerDataSet1 registerDataSet1;
        private System.Windows.Forms.BindingSource zdBindingSource;
        private registerDataSet1TableAdapters.zdTableAdapter zdTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn zds;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdresultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fbdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdmainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdconfirmDataGridViewTextBoxColumn;
    }
}

