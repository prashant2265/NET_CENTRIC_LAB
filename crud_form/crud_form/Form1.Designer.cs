namespace crud_form
{
    partial class update
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
            this.textid = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textaddress = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.btncreate = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnselect = new System.Windows.Forms.Button();
            this.textcontact = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(209, 14);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(100, 22);
            this.textid.TabIndex = 0;
            this.textid.TextChanged += new System.EventHandler(this.textid_TextChanged);
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(209, 61);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 22);
            this.textname.TabIndex = 0;
            // 
            // textaddress
            // 
            this.textaddress.Location = new System.Drawing.Point(209, 115);
            this.textaddress.Name = "textaddress";
            this.textaddress.Size = new System.Drawing.Size(100, 22);
            this.textaddress.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(65, 19);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(50, 16);
            this.id.TabIndex = 1;
            this.id.Text = "User Id";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(65, 67);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(76, 16);
            this.name.TabIndex = 1;
            this.name.Text = "User Name";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(65, 118);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(90, 16);
            this.address.TabIndex = 1;
            this.address.Text = "User Address";
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(20, 295);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(75, 23);
            this.btncreate.TabIndex = 2;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(117, 295);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(215, 295);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(407, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(651, 303);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(310, 294);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 2;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // textcontact
            // 
            this.textcontact.Location = new System.Drawing.Point(209, 162);
            this.textcontact.Name = "textcontact";
            this.textcontact.Size = new System.Drawing.Size(100, 22);
            this.textcontact.TabIndex = 0;
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Location = new System.Drawing.Point(65, 168);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(84, 16);
            this.contact.TabIndex = 1;
            this.contact.Text = "User Contact";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Age";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(209, 201);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(100, 22);
            this.textemail.TabIndex = 5;
            this.textemail.TextChanged += new System.EventHandler(this.textemail_TextChanged);
            // 
            // textage
            // 
            this.textage.Location = new System.Drawing.Point(209, 244);
            this.textage.Name = "textage";
            this.textage.Size = new System.Drawing.Size(100, 22);
            this.textage.TabIndex = 5;
            this.textage.TextChanged += new System.EventHandler(this.textage_TextChanged);
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 393);
            this.Controls.Add(this.textage);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.textcontact);
            this.Controls.Add(this.textaddress);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textid);
            this.Name = "update";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textaddress;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.TextBox textcontact;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textage;
    }
}

