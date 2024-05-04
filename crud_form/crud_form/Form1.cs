using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_form
{
    public partial class update : Form
    {
        SqlConnection con = new SqlConnection("Data source = NITRO-5\\SQLEXPRESS; Initial Catalog=College; Integrated Security = TRUE");
        SqlDataAdapter dat;
        SqlCommand cmd;
        public update()
        {
            InitializeComponent();
        }

       /* void LoadData()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                string query = "SELECT * from student_details";
                dat = new SqlDataAdapter(query, con);
                dat.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally { con.Close(); }
        }*/


        private void update_Load(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            dat = new SqlDataAdapter("Select * from student_details", con);
            dat.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            if (textid.Text != "" && textname.Text != "" && textaddress.Text != "" && textcontact.Text!= "" && textemail.Text != "" && textage.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("Insert into student_details values (@id,@name,@address,@contact,@email,@age)", con);
                cmd.Parameters.AddWithValue("@id", textid.Text.ToString());
                cmd.Parameters.AddWithValue("@name", textname.Text.ToString());
                cmd.Parameters.AddWithValue("@address", textaddress.Text.ToString());
                cmd.Parameters.AddWithValue("@contact", textcontact.Text.ToString());
                cmd.Parameters.AddWithValue("@email", textemail.Text.ToString());
                cmd.Parameters.AddWithValue("@age", textage.Text.ToString());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data created successfully");
                DataTable dt = new DataTable();

                dat.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                textid.Text = "";
                textname.Text = "";
                textaddress.Text = "";
                textcontact.Text = "";
                textemail.Text = "";
                textage.Text = "";

            }
            else
            {
                MessageBox.Show("Can't leave empty textbox");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            if (id.Text != "" && textname.Text != "" && textaddress.Text != "" && textcontact.Text != "" && textemail.Text != "" && textage.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("Update student_details SET id=@id ,name=@name, address=@address ,contact=@contact , email = @email , age=@age where id=@id", con);
                cmd.Parameters.AddWithValue("@id", textid.Text.ToString());
                cmd.Parameters.AddWithValue("@name", textname.Text);
                cmd.Parameters.AddWithValue("@address", textaddress.Text.ToString());
                cmd.Parameters.AddWithValue("@contact", textcontact.Text.ToString());
                cmd.Parameters.AddWithValue("@email", textemail.Text.ToString());
                cmd.Parameters.AddWithValue("@age", textage.Text.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("data updated successfully!");
                DataTable dt = new DataTable();
                dat.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                textid.Text = "";
                textname.Text = "";
                textaddress.Text = "";
                textcontact.Text = "";
                textemail.Text = "";
                textage.Text = "";

            }
            else
            {
                MessageBox.Show("please enter all data!");
            }
        }

        private void textid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new SqlCommand("DELETE FROM student_details WHERE id = @id", con);

            cmd.Parameters.AddWithValue("@id", textid.Text);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Data deleted successfully");
            }
            else
            {
                MessageBox.Show("Error deleting data");
            }
            DataTable dt = new DataTable();
            dat.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            textid.Text = "";
            textname.Text = "";
            textaddress.Text = "";
            textcontact.Text = "";
            textemail.Text = "";
            textage.Text = "";
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
           
        }

     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
            textid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textcontact.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textemail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textage.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();


        }
    }
}

