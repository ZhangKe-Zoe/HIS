namespace DoctorSta
{
    partial class Modelist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cblist = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cblist
            // 
            this.cblist.FormattingEnabled = true;
            this.cblist.Location = new System.Drawing.Point(107, 33);
            this.cblist.Name = "cblist";
            this.cblist.Size = new System.Drawing.Size(140, 20);
            this.cblist.TabIndex = 0;
            this.cblist.SelectedIndexChanged += new System.EventHandler(this.cblist_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请选择替换词：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Modelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 109);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cblist);
            this.Name = "Modelist";
            this.Load += new System.EventHandler(this.Modelist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cblist;
        private System.Windows.Forms.Label label1;
    }
}