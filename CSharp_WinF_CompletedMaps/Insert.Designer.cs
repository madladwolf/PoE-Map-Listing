namespace CSharp_WinF_CompletedMaps
{
    partial class Insert
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
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_extraMission = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.cb_tier = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_layout = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(13, 237);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(179, 87);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.Btn_insert_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(209, 237);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(179, 87);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tier:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Extra Mission:";
            // 
            // cb_extraMission
            // 
            this.cb_extraMission.FormattingEnabled = true;
            this.cb_extraMission.Location = new System.Drawing.Point(92, 117);
            this.cb_extraMission.Name = "cb_extraMission";
            this.cb_extraMission.Size = new System.Drawing.Size(39, 21);
            this.cb_extraMission.TabIndex = 5;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(58, 37);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 6;
            // 
            // cb_tier
            // 
            this.cb_tier.FormattingEnabled = true;
            this.cb_tier.Location = new System.Drawing.Point(48, 80);
            this.cb_tier.Name = "cb_tier";
            this.cb_tier.Size = new System.Drawing.Size(49, 21);
            this.cb_tier.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Layout:";
            // 
            // cb_layout
            // 
            this.cb_layout.FormattingEnabled = true;
            this.cb_layout.Location = new System.Drawing.Point(61, 156);
            this.cb_layout.Name = "cb_layout";
            this.cb_layout.Size = new System.Drawing.Size(70, 21);
            this.cb_layout.TabIndex = 9;
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 334);
            this.Controls.Add(this.cb_layout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_tier);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.cb_extraMission);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_insert);
            this.Name = "Insert";
            this.Text = "Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_extraMission;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox cb_tier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_layout;
    }
}