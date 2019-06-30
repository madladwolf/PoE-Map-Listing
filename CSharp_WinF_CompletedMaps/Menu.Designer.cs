namespace CSharp_WinF_CompletedMaps
{
    partial class Menu
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
            this.txt_insert = new System.Windows.Forms.Button();
            this.txt_list = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_insert
            // 
            this.txt_insert.Location = new System.Drawing.Point(16, 12);
            this.txt_insert.Name = "txt_insert";
            this.txt_insert.Size = new System.Drawing.Size(173, 130);
            this.txt_insert.TabIndex = 0;
            this.txt_insert.Text = "Insert";
            this.txt_insert.UseVisualStyleBackColor = true;
            this.txt_insert.Click += new System.EventHandler(this.Txt_insert_Click);
            // 
            // txt_list
            // 
            this.txt_list.Location = new System.Drawing.Point(16, 148);
            this.txt_list.Name = "txt_list";
            this.txt_list.Size = new System.Drawing.Size(173, 130);
            this.txt_list.TabIndex = 1;
            this.txt_list.Text = "List";
            this.txt_list.UseVisualStyleBackColor = true;
            this.txt_list.Click += new System.EventHandler(this.Txt_list_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(16, 284);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(173, 77);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 373);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_list);
            this.Controls.Add(this.txt_insert);
            this.Name = "Menu";
            this.Text = "Map Register";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txt_insert;
        private System.Windows.Forms.Button txt_list;
        private System.Windows.Forms.Button btn_exit;
    }
}

