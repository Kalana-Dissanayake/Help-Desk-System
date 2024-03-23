namespace heldesp_ui
{
    partial class Form4
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
            this.lbl_time = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_ext = new System.Windows.Forms.Button();
            this.dgv_4 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_slo = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pnoms = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(78, 219);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(33, 13);
            this.lbl_time.TabIndex = 2;
            this.lbl_time.Text = "Time:";
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(121, 216);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(183, 20);
            this.txt_time.TabIndex = 5;
            this.txt_time.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(28, 359);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(87, 32);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_ext
            // 
            this.btn_ext.Location = new System.Drawing.Point(130, 359);
            this.btn_ext.Name = "btn_ext";
            this.btn_ext.Size = new System.Drawing.Size(85, 32);
            this.btn_ext.TabIndex = 8;
            this.btn_ext.Text = "Back";
            this.btn_ext.UseVisualStyleBackColor = true;
            this.btn_ext.Click += new System.EventHandler(this.btn_ext_Click);
            // 
            // dgv_4
            // 
            this.dgv_4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_4.Location = new System.Drawing.Point(337, 32);
            this.dgv_4.Name = "dgv_4";
            this.dgv_4.Size = new System.Drawing.Size(362, 320);
            this.dgv_4.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Check Problem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Solution:";
            // 
            // txt_slo
            // 
            this.txt_slo.Location = new System.Drawing.Point(121, 103);
            this.txt_slo.Name = "txt_slo";
            this.txt_slo.Size = new System.Drawing.Size(183, 83);
            this.txt_slo.TabIndex = 6;
            this.txt_slo.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ProblemNo:";
            // 
            // txt_pnoms
            // 
            this.txt_pnoms.Location = new System.Drawing.Point(121, 48);
            this.txt_pnoms.Name = "txt_pnoms";
            this.txt_pnoms.Size = new System.Drawing.Size(183, 20);
            this.txt_pnoms.TabIndex = 3;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 460);
            this.Controls.Add(this.dgv_4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ext);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_slo);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.txt_pnoms);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Form4";
            this.Text = "Specialist";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_ext;
        private System.Windows.Forms.DataGridView dgv_4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_slo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pnoms;
    }
}