using System.Data;
using System.Data.SqlClient;
using Turbo.az.Connection;

namespace Turbo.az
{
    public partial class Admin : Form
    {
        SqlConnection conect = new SqlConnection(Connect.conection);
        int id = 0;
        public Admin()
        {
            InitializeComponent();
        }
        public void getall1()
        {
            try
            {
                conect.Open();
                string script = "SELECT * FROM Elan";
                SqlCommand command = new SqlCommand(script, conect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conect.Close(); }
        }
        public void getall2()
        {
            try
            {
                conect.Open();
                string script = "SELECT * FROM Contact";
                SqlCommand command = new SqlCommand(script, conect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView2.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conect.Close();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            getall1();
            getall2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        public void searc1()
        {
            try
            {
                conect.Open();
                string script = "SELECT * FROM Elan WHERE Brand=@brand";
                SqlCommand command = new SqlCommand(script, conect);
                command.Parameters.AddWithValue("@brand", textBox1.Text);
                SqlDataAdapter dt = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conect.Close(); }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            searc1();
        }
        public void delete1(int id)
        {
            try
            {
                conect.Open();
                string script = "DELETE FROM Elan WHERE ID=@id";
                SqlCommand command = new SqlCommand(script, conect);
                command.Parameters.AddWithValue("@id", id);
                SqlDataAdapter dt = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dt.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conect.Close(); }
        }
        public void delete2(int id)
        {
            try
            {
                conect.Open();
                string script = "DELETE FROM Contact WHERE ID=@id";
                SqlCommand command = new SqlCommand(script, conect);
                command.Parameters.AddWithValue("@id", id);
                SqlDataAdapter dt = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dt.Fill(dataTable);
                dataGridView2.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conect.Close(); }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                id = Convert.ToInt32(item.Cells[0].Value);
                delete1(id);
                getall1();
            }
            foreach (DataGridViewRow item in dataGridView2.SelectedRows)
            {
                id = Convert.ToInt32(item.Cells[0].Value);
                delete2(id);
                getall2();
            }
        }
        public void update(int id)
        {
            /*Typeofban=@typeofban,March = @march,Color = @color*/
            try
            {
                conect.Open();
                string script = @"UPDATE Elan SET Brand=@brand,Model=@model,Typeofban=@typeofban,
                                  March=@march,Color = @color WHERE ID=@id";
                SqlCommand command = new SqlCommand(script, conect);
                command.Parameters.AddWithValue("@brand", textBox2.Text);
                command.Parameters.AddWithValue("@model", textBox6.Text);
                command.Parameters.AddWithValue("@typeofban", textBox5.Text);
                command.Parameters.AddWithValue("@march", textBox4.Text);
                command.Parameters.AddWithValue("@color", textBox7.Text);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                MessageBox.Show("Elan derc edildi");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                conect.Close();
            }
        }
        int i = 0;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(item.Cells[0].Value);
                update(id);
                getall1();
            }
        }
    }
}
