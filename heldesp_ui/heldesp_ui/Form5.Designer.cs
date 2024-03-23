namespace heldesp_ui
{
    partial class Form5
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_callerid = new System.Windows.Forms.TextBox();
            this.txt_oid = new System.Windows.Forms.TextBox();
            this.txt_pno = new System.Windows.Forms.TextBox();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.txt_pro = new System.Windows.Forms.RichTextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_spec = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Caller ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Problem Number:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Operator ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Problem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Time:";
            // 
            // txt_callerid
            // 
            this.txt_callerid.Location = new System.Drawing.Point(71, 114);
            this.txt_callerid.Name = "txt_callerid";
            this.txt_callerid.Size = new System.Drawing.Size(119, 20);
            this.txt_callerid.TabIndex = 1;
            // 
            // txt_oid
            // 
            this.txt_oid.Location = new System.Drawing.Point(86, 40);
            this.txt_oid.Name = "txt_oid";
            this.txt_oid.Size = new System.Drawing.Size(119, 20);
            this.txt_oid.TabIndex = 1;
            // 
            // txt_pno
            // 
            this.txt_pno.Location = new System.Drawing.Point(334, 40);
            this.txt_pno.Name = "txt_pno";
            this.txt_pno.Size = new System.Drawing.Size(119, 20);
            this.txt_pno.TabIndex = 1;
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(279, 114);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(119, 20);
            this.txt_time.TabIndex = 1;
            // 
            // txt_pro
            // 
            this.txt_pro.Location = new System.Drawing.Point(71, 196);
            this.txt_pro.Name = "txt_pro";
            this.txt_pro.Size = new System.Drawing.Size(303, 58);
            this.txt_pro.TabIndex = 2;
            this.txt_pro.Text = "";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(131, 294);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Insert";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_spec
            // 
            this.btn_spec.Location = new System.Drawing.Point(218, 294);
            this.btn_spec.Name = "btn_spec";
            this.btn_spec.Size = new System.Drawing.Size(75, 23);
            this.btn_spec.TabIndex = 4;
            this.btn_spec.Text = "Specialist";
            this.btn_spec.UseVisualStyleBackColor = true;
            this.btn_spec.Click += new System.EventHandler(this.btn_spec_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(299, 293);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 343);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_spec);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_pro);
            this.Controls.Add(this.txt_callerid);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.txt_pno);
            this.Controls.Add(this.txt_oid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_callerid;
        private System.Windows.Forms.TextBox txt_oid;
        private System.Windows.Forms.TextBox txt_pno;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.RichTextBox txt_pro;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_spec;
        private System.Windows.Forms.Button btn_back;
    }
}