namespace heldesp_ui
{
    partial class Form3
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
            this.lbl_dsc = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.txt_dsc = new System.Windows.Forms.RichTextBox();
            this.btn_rep = new System.Windows.Forms.Button();
            this.btn_spec = new System.Windows.Forms.Button();
            this.lbl_sol = new System.Windows.Forms.Label();
            this.txt_sol = new System.Windows.Forms.RichTextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_ope = new System.Windows.Forms.Label();
            this.txt_oid = new System.Windows.Forms.TextBox();
            this.dgv_3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.combo_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sid = new System.Windows.Forms.TextBox();
            this.btn_call = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_eid = new System.Windows.Forms.TextBox();
            this.txt_pno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dsc
            // 
            this.lbl_dsc.AutoSize = true;
            this.lbl_dsc.Location = new System.Drawing.Point(12, 135);
            this.lbl_dsc.Name = "lbl_dsc";
            this.lbl_dsc.Size = new System.Drawing.Size(59, 13);
            this.lbl_dsc.TabIndex = 1;
            this.lbl_dsc.Text = "Discription:";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(37, 59);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(34, 13);
            this.lbl_type.TabIndex = 2;
            this.lbl_type.Text = "Type:";
            // 
            // txt_dsc
            // 
            this.txt_dsc.Location = new System.Drawing.Point(80, 104);
            this.txt_dsc.Name = "txt_dsc";
            this.txt_dsc.Size = new System.Drawing.Size(339, 96);
            this.txt_dsc.TabIndex = 6;
            this.txt_dsc.Text = "";
            // 
            // btn_rep
            // 
            this.btn_rep.Location = new System.Drawing.Point(624, 311);
            this.btn_rep.Name = "btn_rep";
            this.btn_rep.Size = new System.Drawing.Size(111, 39);
            this.btn_rep.TabIndex = 7;
            this.btn_rep.Text = "Recent Problems";
            this.btn_rep.UseVisualStyleBackColor = true;
            this.btn_rep.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_spec
            // 
            this.btn_spec.Location = new System.Drawing.Point(634, 270);
            this.btn_spec.Name = "btn_spec";
            this.btn_spec.Size = new System.Drawing.Size(93, 38);
            this.btn_spec.TabIndex = 9;
            this.btn_spec.Text = "Check Specialists";
            this.btn_spec.UseVisualStyleBackColor = true;
            this.btn_spec.Click += new System.EventHandler(this.btn_spec_Click);
            // 
            // lbl_sol
            // 
            this.lbl_sol.AutoSize = true;
            this.lbl_sol.Location = new System.Drawing.Point(12, 259);
            this.lbl_sol.Name = "lbl_sol";
            this.lbl_sol.Size = new System.Drawing.Size(48, 13);
            this.lbl_sol.TabIndex = 10;
            this.lbl_sol.Text = "Solution:";
            // 
            // txt_sol
            // 
            this.txt_sol.Location = new System.Drawing.Point(80, 228);
            this.txt_sol.Name = "txt_sol";
            this.txt_sol.Size = new System.Drawing.Size(339, 96);
            this.txt_sol.TabIndex = 11;
            this.txt_sol.Text = "";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(535, 277);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(93, 28);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_ope
            // 
            this.lbl_ope.AutoSize = true;
            this.lbl_ope.Location = new System.Drawing.Point(481, 122);
            this.lbl_ope.Name = "lbl_ope";
            this.lbl_ope.Size = new System.Drawing.Size(33, 13);
            this.lbl_ope.TabIndex = 13;
            this.lbl_ope.Text = "Date:";
            this.lbl_ope.Click += new System.EventHandler(this.lbl_ope_Click);
            // 
            // txt_oid
            // 
            this.txt_oid.Location = new System.Drawing.Point(80, 10);
            this.txt_oid.Name = "txt_oid";
            this.txt_oid.Size = new System.Drawing.Size(115, 20);
            this.txt_oid.TabIndex = 14;
            // 
            // dgv_3
            // 
            this.dgv_3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_3.Location = new System.Drawing.Point(12, 356);
            this.dgv_3.Name = "dgv_3";
            this.dgv_3.Size = new System.Drawing.Size(723, 201);
            this.dgv_3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "OperatorID:";
            this.label1.Click += new System.EventHandler(this.lbl_ope_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Time:";
            this.label2.Click += new System.EventHandler(this.lbl_ope_Click);
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(520, 160);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(117, 20);
            this.txt_time.TabIndex = 5;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(520, 118);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(117, 20);
            this.txt_date.TabIndex = 5;
            // 
            // combo_type
            // 
            this.combo_type.FormattingEnabled = true;
            this.combo_type.Location = new System.Drawing.Point(80, 59);
            this.combo_type.Name = "combo_type";
            this.combo_type.Size = new System.Drawing.Size(121, 21);
            this.combo_type.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "SpecialistID:";
            this.label3.Click += new System.EventHandler(this.lbl_ope_Click);
            // 
            // txt_sid
            // 
            this.txt_sid.Location = new System.Drawing.Point(303, 6);
            this.txt_sid.Name = "txt_sid";
            this.txt_sid.Size = new System.Drawing.Size(116, 20);
            this.txt_sid.TabIndex = 14;
            // 
            // btn_call
            // 
            this.btn_call.Location = new System.Drawing.Point(535, 317);
            this.btn_call.Name = "btn_call";
            this.btn_call.Size = new System.Drawing.Size(83, 27);
            this.btn_call.TabIndex = 17;
            this.btn_call.Text = "Call";
            this.btn_call.UseVisualStyleBackColor = true;
            this.btn_call.Click += new System.EventHandler(this.btn_call_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(652, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "EquipmentID:";
            this.label5.Click += new System.EventHandler(this.lbl_ope_Click);
            // 
            // txt_eid
            // 
            this.txt_eid.Location = new System.Drawing.Point(303, 56);
            this.txt_eid.Name = "txt_eid";
            this.txt_eid.Size = new System.Drawing.Size(116, 20);
            this.txt_eid.TabIndex = 14;
            // 
            // txt_pno
            // 
            this.txt_pno.Location = new System.Drawing.Point(520, 6);
            this.txt_pno.Name = "txt_pno";
            this.txt_pno.Size = new System.Drawing.Size(115, 20);
            this.txt_pno.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ProblemNo:";
            this.label4.Click += new System.EventHandler(this.lbl_ope_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 569);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_call);
            this.Controls.Add(this.combo_type);
            this.Controls.Add(this.dgv_3);
            this.Controls.Add(this.txt_pno);
            this.Controls.Add(this.txt_eid);
            this.Controls.Add(this.txt_sid);
            this.Controls.Add(this.txt_oid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ope);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_sol);
            this.Controls.Add(this.lbl_sol);
            this.Controls.Add(this.btn_spec);
            this.Controls.Add(this.btn_rep);
            this.Controls.Add(this.txt_dsc);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_dsc);
            this.Name = "Form3";
            this.Text = "Operator";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dsc;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.RichTextBox txt_dsc;
        private System.Windows.Forms.Button btn_rep;
        private System.Windows.Forms.Button btn_spec;
        private System.Windows.Forms.Label lbl_sol;
        private System.Windows.Forms.RichTextBox txt_sol;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_ope;
        private System.Windows.Forms.TextBox txt_oid;
        private System.Windows.Forms.DataGridView dgv_3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.ComboBox combo_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sid;
        private System.Windows.Forms.Button btn_call;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_eid;
        private System.Windows.Forms.TextBox txt_pno;
        private System.Windows.Forms.Label label4;
    }
}