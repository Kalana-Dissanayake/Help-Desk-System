namespace heldesp_ui
{
    partial class Form1
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
            this.lbl_sn = new System.Windows.Forms.Label();
            this.txt_sn = new System.Windows.Forms.TextBox();
            this.lbl_os = new System.Windows.Forms.Label();
            this.txt_os = new System.Windows.Forms.TextBox();
            this.lbl_sft = new System.Windows.Forms.Label();
            this.txt_sft = new System.Windows.Forms.TextBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.btn_chk = new System.Windows.Forms.Button();
            this.btn_log_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_clname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_sn
            // 
            this.lbl_sn.AutoSize = true;
            this.lbl_sn.Location = new System.Drawing.Point(64, 49);
            this.lbl_sn.Name = "lbl_sn";
            this.lbl_sn.Size = new System.Drawing.Size(53, 13);
            this.lbl_sn.TabIndex = 0;
            this.lbl_sn.Text = "Serial No:";
            this.lbl_sn.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_sn
            // 
            this.txt_sn.Location = new System.Drawing.Point(140, 46);
            this.txt_sn.Name = "txt_sn";
            this.txt_sn.Size = new System.Drawing.Size(182, 20);
            this.txt_sn.TabIndex = 1;
            // 
            // lbl_os
            // 
            this.lbl_os.AutoSize = true;
            this.lbl_os.Location = new System.Drawing.Point(94, 99);
            this.lbl_os.Name = "lbl_os";
            this.lbl_os.Size = new System.Drawing.Size(23, 13);
            this.lbl_os.TabIndex = 2;
            this.lbl_os.Text = "Os:";
            // 
            // txt_os
            // 
            this.txt_os.Location = new System.Drawing.Point(140, 96);
            this.txt_os.Name = "txt_os";
            this.txt_os.Size = new System.Drawing.Size(182, 20);
            this.txt_os.TabIndex = 3;
            // 
            // lbl_sft
            // 
            this.lbl_sft.AutoSize = true;
            this.lbl_sft.Location = new System.Drawing.Point(65, 151);
            this.lbl_sft.Name = "lbl_sft";
            this.lbl_sft.Size = new System.Drawing.Size(52, 13);
            this.lbl_sft.TabIndex = 4;
            this.lbl_sft.Text = "Software:";
            // 
            // txt_sft
            // 
            this.txt_sft.Location = new System.Drawing.Point(140, 148);
            this.txt_sft.Name = "txt_sft";
            this.txt_sft.Size = new System.Drawing.Size(182, 20);
            this.txt_sft.TabIndex = 5;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(84, 198);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(33, 13);
            this.lbl_time.TabIndex = 6;
            this.lbl_time.Text = "Time:";
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(140, 195);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(182, 20);
            this.txt_time.TabIndex = 7;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(97, 310);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(95, 34);
            this.btn_next.TabIndex = 8;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // dgv_1
            // 
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Location = new System.Drawing.Point(380, 59);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.Size = new System.Drawing.Size(389, 285);
            this.dgv_1.TabIndex = 9;
            // 
            // btn_chk
            // 
            this.btn_chk.Location = new System.Drawing.Point(380, 351);
            this.btn_chk.Name = "btn_chk";
            this.btn_chk.Size = new System.Drawing.Size(75, 23);
            this.btn_chk.TabIndex = 10;
            this.btn_chk.Text = "Check";
            this.btn_chk.UseVisualStyleBackColor = true;
            this.btn_chk.Click += new System.EventHandler(this.btn_chk_Click);
            // 
            // btn_log_add
            // 
            this.btn_log_add.Location = new System.Drawing.Point(198, 310);
            this.btn_log_add.Name = "btn_log_add";
            this.btn_log_add.Size = new System.Drawing.Size(95, 34);
            this.btn_log_add.TabIndex = 11;
            this.btn_log_add.Text = "ADD";
            this.btn_log_add.UseVisualStyleBackColor = true;
            this.btn_log_add.Click += new System.EventHandler(this.btn_log_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caller Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_clname
            // 
            this.txt_clname.Location = new System.Drawing.Point(140, 245);
            this.txt_clname.Name = "txt_clname";
            this.txt_clname.Size = new System.Drawing.Size(182, 20);
            this.txt_clname.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 386);
            this.Controls.Add(this.btn_log_add);
            this.Controls.Add(this.btn_chk);
            this.Controls.Add(this.dgv_1);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.txt_sft);
            this.Controls.Add(this.lbl_sft);
            this.Controls.Add(this.txt_os);
            this.Controls.Add(this.lbl_os);
            this.Controls.Add(this.txt_clname);
            this.Controls.Add(this.txt_sn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_sn);
            this.Name = "Form1";
            this.Text = "Loging";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sn;
        private System.Windows.Forms.TextBox txt_sn;
        private System.Windows.Forms.Label lbl_os;
        private System.Windows.Forms.TextBox txt_os;
        private System.Windows.Forms.Label lbl_sft;
        private System.Windows.Forms.TextBox txt_sft;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.Button btn_chk;
        private System.Windows.Forms.Button btn_log_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_clname;
    }
}

