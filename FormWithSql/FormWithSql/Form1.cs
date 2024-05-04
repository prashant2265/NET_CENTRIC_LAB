using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormWithSql
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data source = NITRO-5\\SQLEXPRESS; Initial Catalog=College; Integrated Security = TRUE");
        SqlDataAdapter dat;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* if (textname.Text != "" && textphone.Text != "")
             {
                 con.Open();
                 cmd = new SqlCommand("UPDATE student_details SET name = @name, [Phone No] = @phone WHERE Id = @id", con);
                 cmd.Parameters.AddWithValue("@id", textid.Text.ToString());
                 cmd.Parameters.AddWithValue("@name", textname.Text);
                 cmd.Parameters.AddWithValue("@phone", textphone.Text.ToString());
                 int rowsAffected = cmd.ExecuteNonQuery();
                 if (rowsAffected > 0)
                 {
                     MessageBox.Show("Data updated successfully");
                 }
                 else
                 {
                     MessageBox.Show("Error updating data");
                 }
                 DataTable dt = new DataTable();
                 dat.Fill(dt);
                 dataGridView1.DataSource = dt;
                 con.Close();
                 textid.Text = "";
                 textname.Text = "";
                textphone.Text = "";
             }
             else
             {
                 MessageBox.Show("Can't leave empty textbox");
             }
         }*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
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
            if (textid.Text != "" && textname.Text != "" && textaddress.Text != "" && textphone.Text! == "")
            {
                con.Open();
                cmd = new SqlCommand("Insert into student_details values (@id,@name,@address,@contact)", con);
                cmd.Parameters.AddWithValue("@id", textid.Text.ToString());
                cmd.Parameters.AddWithValue("@name", textname.Text.ToString());
                cmd.Parameters.AddWithValue("@address", textaddress.Text.ToString());
                cmd.Parameters.AddWithValue("@contact", textphone.Text.ToString());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data inserted successfully");
                DataTable dt = new DataTable();
                
                dat.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                textid.Text = "";
                textname.Text = "";
                textaddress.Text = "";
                textphone.Text = "";

            }
            else
            {
                MessageBox.Show("Can't leave empty textbox");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void btnselect_Click(object sender, EventArgs e)
        {

        }

        private void textid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textaddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
