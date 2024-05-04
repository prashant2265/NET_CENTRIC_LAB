namespace FormWithSql
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textid = new TextBox();
            textname = new TextBox();
            textphone = new TextBox();
            btncreate = new Button();
            btnupdate = new Button();
            btndelete = new Button();
            btnselect = new Button();
            dataGridView1 = new DataGridView();
            textaddress = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 26);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "User Record";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 73);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 0;
            label2.Text = "User id";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 118);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 0;
            label3.Text = "User Name";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 212);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 0;
            label4.Text = "User Phone";
            label4.Click += label1_Click;
            // 
            // textid
            // 
            textid.Location = new Point(300, 73);
            textid.Name = "textid";
            textid.Size = new Size(125, 27);
            textid.TabIndex = 1;
            textid.TextChanged += textid_TextChanged;
            // 
            // textname
            // 
            textname.Location = new Point(300, 118);
            textname.Name = "textname";
            textname.Size = new Size(125, 27);
            textname.TabIndex = 1;
            textname.TextChanged += textname_TextChanged;
            // 
            // textphone
            // 
            textphone.Location = new Point(300, 212);
            textphone.Name = "textphone";
            textphone.Size = new Size(125, 27);
            textphone.TabIndex = 1;
            textphone.TextChanged += textBox3_TextChanged;
            // 
            // btncreate
            // 
            btncreate.Location = new Point(157, 281);
            btncreate.Name = "btncreate";
            btncreate.Size = new Size(94, 29);
            btncreate.TabIndex = 2;
            btncreate.Text = "Create";
            btncreate.UseVisualStyleBackColor = true;
            btncreate.Click += btncreate_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(262, 281);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(94, 29);
            btnupdate.TabIndex = 2;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += button2_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(373, 281);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(94, 29);
            btndelete.TabIndex = 2;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnselect
            // 
            btnselect.Location = new Point(499, 281);
            btnselect.Name = "btnselect";
            btnselect.Size = new Size(94, 29);
            btnselect.TabIndex = 2;
            btnselect.Text = "Select";
            btnselect.UseVisualStyleBackColor = true;
            btnselect.Click += btnselect_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(185, 332);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(458, 188);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textaddress
            // 
            textaddress.Location = new Point(300, 169);
            textaddress.Name = "textaddress";
            textaddress.Size = new Size(125, 27);
            textaddress.TabIndex = 1;
            textaddress.TextChanged += textaddress_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 169);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 0;
            label5.Text = "User Address";
            label5.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 573);
            Controls.Add(dataGridView1);
            Controls.Add(btnselect);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btncreate);
            Controls.Add(textphone);
            Controls.Add(textaddress);
            Controls.Add(textname);
            Controls.Add(textid);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textid;
        private TextBox textname;
        private TextBox textphone;
        private Button btncreate;
        private Button btnupdate;
        private Button btndelete;
        private Button btnselect;
        private DataGridView dataGridView1;
        private TextBox textaddress;
        private Label label5;
    }
}
