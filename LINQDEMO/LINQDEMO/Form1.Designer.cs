namespace LINQDEMO
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteCustomer = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.UPDATECUSTOMER = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtContactNoUpdate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBoxEmail = new System.Windows.Forms.TextBox();
            this.TxtNameforUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.ADDCUSTOMER = new System.Windows.Forms.TabPage();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtMaskedContactNo = new System.Windows.Forms.MaskedTextBox();
            this.DTPDOB = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DeleteCustomer.SuspendLayout();
            this.UPDATECUSTOMER.SuspendLayout();
            this.ADDCUSTOMER.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Yellow;
            this.dataGridView1.Location = new System.Drawing.Point(29, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(820, 144);
            this.dataGridView1.TabIndex = 0;
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.BackColor = System.Drawing.Color.DarkOrange;
            this.DeleteCustomer.Controls.Add(this.button3);
            this.DeleteCustomer.Controls.Add(this.comboBox1);
            this.DeleteCustomer.Location = new System.Drawing.Point(4, 40);
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.Size = new System.Drawing.Size(812, 290);
            this.DeleteCustomer.TabIndex = 2;
            this.DeleteCustomer.Text = "DeleteCustomer";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(308, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 56);
            this.button3.TabIndex = 1;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(253, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(289, 39);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UPDATECUSTOMER
            // 
            this.UPDATECUSTOMER.BackColor = System.Drawing.Color.Fuchsia;
            this.UPDATECUSTOMER.Controls.Add(this.button2);
            this.UPDATECUSTOMER.Controls.Add(this.TxtContactNoUpdate);
            this.UPDATECUSTOMER.Controls.Add(this.label4);
            this.UPDATECUSTOMER.Controls.Add(this.TxtBoxEmail);
            this.UPDATECUSTOMER.Controls.Add(this.TxtNameforUpdate);
            this.UPDATECUSTOMER.Controls.Add(this.label5);
            this.UPDATECUSTOMER.Controls.Add(this.Name);
            this.UPDATECUSTOMER.Controls.Add(this.listBox2);
            this.UPDATECUSTOMER.Location = new System.Drawing.Point(4, 40);
            this.UPDATECUSTOMER.Name = "UPDATECUSTOMER";
            this.UPDATECUSTOMER.Padding = new System.Windows.Forms.Padding(3);
            this.UPDATECUSTOMER.Size = new System.Drawing.Size(812, 290);
            this.UPDATECUSTOMER.TabIndex = 1;
            this.UPDATECUSTOMER.Text = "UpdateCustomer";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Purple;
            this.button2.Location = new System.Drawing.Point(373, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 63);
            this.button2.TabIndex = 7;
            this.button2.Text = "UpdateCustomer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtContactNoUpdate
            // 
            this.TxtContactNoUpdate.Location = new System.Drawing.Point(373, 110);
            this.TxtContactNoUpdate.Mask = "(999) 000-0000";
            this.TxtContactNoUpdate.Name = "TxtContactNoUpdate";
            this.TxtContactNoUpdate.Size = new System.Drawing.Size(212, 38);
            this.TxtContactNoUpdate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "ContactNo";
            // 
            // TxtBoxEmail
            // 
            this.TxtBoxEmail.Location = new System.Drawing.Point(373, 66);
            this.TxtBoxEmail.Name = "TxtBoxEmail";
            this.TxtBoxEmail.Size = new System.Drawing.Size(212, 38);
            this.TxtBoxEmail.TabIndex = 4;
            // 
            // TxtNameforUpdate
            // 
            this.TxtNameforUpdate.Location = new System.Drawing.Point(373, 20);
            this.TxtNameforUpdate.Name = "TxtNameforUpdate";
            this.TxtNameforUpdate.Size = new System.Drawing.Size(212, 38);
            this.TxtNameforUpdate.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(244, 20);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(90, 31);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 31;
            this.listBox2.Location = new System.Drawing.Point(6, 6);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(207, 252);
            this.listBox2.TabIndex = 0;
            this.listBox2.Click += new System.EventHandler(this.listBox2_Click);
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBox2.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.listBox2_ChangeUICues);
            // 
            // ADDCUSTOMER
            // 
            this.ADDCUSTOMER.BackColor = System.Drawing.Color.Lime;
            this.ADDCUSTOMER.Controls.Add(this.TxtEmail);
            this.ADDCUSTOMER.Controls.Add(this.button1);
            this.ADDCUSTOMER.Controls.Add(this.TxtMaskedContactNo);
            this.ADDCUSTOMER.Controls.Add(this.DTPDOB);
            this.ADDCUSTOMER.Controls.Add(this.label3);
            this.ADDCUSTOMER.Controls.Add(this.TxtName);
            this.ADDCUSTOMER.Controls.Add(this.Email);
            this.ADDCUSTOMER.Controls.Add(this.label1);
            this.ADDCUSTOMER.Controls.Add(this.Name1);
            this.ADDCUSTOMER.Location = new System.Drawing.Point(4, 40);
            this.ADDCUSTOMER.Name = "ADDCUSTOMER";
            this.ADDCUSTOMER.Padding = new System.Windows.Forms.Padding(3);
            this.ADDCUSTOMER.Size = new System.Drawing.Size(812, 290);
            this.ADDCUSTOMER.TabIndex = 0;
            this.ADDCUSTOMER.Text = "AddCustomer";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(324, 103);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(223, 38);
            this.TxtEmail.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(308, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "AddNewCustomer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtMaskedContactNo
            // 
            this.TxtMaskedContactNo.Location = new System.Drawing.Point(324, 61);
            this.TxtMaskedContactNo.Mask = "(999) 000-0000";
            this.TxtMaskedContactNo.Name = "TxtMaskedContactNo";
            this.TxtMaskedContactNo.Size = new System.Drawing.Size(223, 38);
            this.TxtMaskedContactNo.TabIndex = 8;
            // 
            // DTPDOB
            // 
            this.DTPDOB.Location = new System.Drawing.Point(289, 152);
            this.DTPDOB.Name = "DTPDOB";
            this.DTPDOB.Size = new System.Drawing.Size(334, 38);
            this.DTPDOB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "DOB";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(324, 17);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(223, 38);
            this.TxtName.TabIndex = 1;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(178, 103);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(86, 31);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "ContactNo";
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Location = new System.Drawing.Point(174, 17);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(90, 31);
            this.Name1.TabIndex = 0;
            this.Name1.Text = "Name";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ADDCUSTOMER);
            this.tabControl1.Controls.Add(this.UPDATECUSTOMER);
            this.tabControl1.Controls.Add(this.DeleteCustomer);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(25, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 334);
            this.tabControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(945, 570);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Maroon;
            //this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DeleteCustomer.ResumeLayout(false);
            this.UPDATECUSTOMER.ResumeLayout(false);
            this.UPDATECUSTOMER.PerformLayout();
            this.ADDCUSTOMER.ResumeLayout(false);
            this.ADDCUSTOMER.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage DeleteCustomer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage UPDATECUSTOMER;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox TxtContactNoUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBoxEmail;
        private System.Windows.Forms.TextBox TxtNameforUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TabPage ADDCUSTOMER;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox TxtMaskedContactNo;
        private System.Windows.Forms.DateTimePicker DTPDOB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox TxtEmail;
    }
}

