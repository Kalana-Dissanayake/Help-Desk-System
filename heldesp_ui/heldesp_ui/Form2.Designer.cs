namespace heldesp_ui
{
    partial class Form2
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
            this.lbl_cn = new System.Windows.Forms.Label();
            this.txt_cn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_eq_id = new System.Windows.Forms.TextBox();
            this.btn_chk_2 = new System.Windows.Forms.Button();
            this.btn_nxt = new System.Windows.Forms.Button();
            this.dgv_2 = new System.Windows.Forms.DataGridView();
            this.btn_chk_cn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cn
            // 
            this.lbl_cn.AutoSize = true;
            this.lbl_cn.Location = new System.Drawing.Point(92, 49);
            this.lbl_cn.Name = "lbl_cn";
            this.lbl_cn.Size = new System.Drawing.Size(67, 13);
            this.lbl_cn.TabIndex = 0;
            this.lbl_cn.Text = "Caller Name:";
            // 
            // txt_cn
            // 
            this.txt_cn.Location = new System.Drawing.Point(195, 46);
            this.txt_cn.Name = "txt_cn";
            this.txt_cn.Size = new System.Drawing.Size(177, 20);
            this.txt_cn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "EquipmentID:";
            // 
            // txt_eq_id
            // 
            this.txt_eq_id.Location = new System.Drawing.Point(195, 107);
            this.txt_eq_id.Name = "txt_eq_id";
            this.txt_eq_id.Size = new System.Drawing.Size(177, 20);
            this.txt_eq_id.TabIndex = 3;
            // 
            // btn_chk_2
            // 
            this.btn_chk_2.BackColor = System.Drawing.Color.Transparent;
            this.btn_chk_2.Location = new System.Drawing.Point(390, 105);
            this.btn_chk_2.Name = "btn_chk_2";
            this.btn_chk_2.Size = new System.Drawing.Size(75, 23);
            this.btn_chk_2.TabIndex = 4;
            this.btn_chk_2.Text = "Check";
            this.btn_chk_2.UseVisualStyleBackColor = false;
            this.btn_chk_2.Click += new System.EventHandler(this.btn_chk_Click);
            // 
            // btn_nxt
            // 
            this.btn_nxt.Location = new System.Drawing.Point(259, 165);
            this.btn_nxt.Name = "btn_nxt";
            this.btn_nxt.Size = new System.Drawing.Size(75, 23);
            this.btn_nxt.TabIndex = 5;
            this.btn_nxt.Text = "Next";
            this.btn_nxt.UseVisualStyleBackColor = true;
            this.btn_nxt.Click += new System.EventHandler(this.btn_nxt_Click);
            // 
            // dgv_2
            // 
            this.dgv_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_2.Location = new System.Drawing.Point(12, 208);
            this.dgv_2.Name = "dgv_2";
            this.dgv_2.Size = new System.Drawing.Size(502, 220);
            this.dgv_2.TabIndex = 6;
            // 
            // btn_chk_cn
            // 
            this.btn_chk_cn.Location = new System.Drawing.Point(390, 46);
            this.btn_chk_cn.Name = "btn_chk_cn";
            this.btn_chk_cn.Size = new System.Drawing.Size(75, 23);
            this.btn_chk_cn.TabIndex = 7;
            this.btn_chk_cn.Text = "Check";
            this.btn_chk_cn.UseVisualStyleBackColor = true;
            this.btn_chk_cn.Click += new System.EventHandler(this.btn_chk_cn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 440);
            this.Controls.Add(this.btn_chk_cn);
            this.Controls.Add(this.dgv_2);
            this.Controls.Add(this.btn_nxt);
            this.Controls.Add(this.btn_chk_2);
            this.Controls.Add(this.txt_eq_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cn);
            this.Controls.Add(this.lbl_cn);
            this.Name = "Form2";
            this.Text = "Check";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cn;
        private System.Windows.Forms.TextBox txt_cn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_eq_id;
        private System.Windows.Forms.Button btn_chk_2;
        private System.Windows.Forms.Button btn_nxt;
        private System.Windows.Forms.DataGridView dgv_2;
        private System.Windows.Forms.Button btn_chk_cn;
    }
}