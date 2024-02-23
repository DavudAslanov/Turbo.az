using System.Data.SqlClient;
using Turbo.az.Connection;

namespace Turbo.az
{
    public partial class Form1 : Form
    {

        SqlConnection conect = new SqlConnection(Connect.conection);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Insert1()
        {
            try
            {
                conect.Open();
                string script = @"INSERT INTO Elan(Brand,Model,Typeofban,March,Color,Price,Theowner,Fueltype,Transmitter,Speedometer,Newyear,Enginevolume,Enginepower,Collected,Ýnformation)
                                            VALUES(@brand,@model,@typeofban,@march,@color,@price,@theowner,@fueltype,@transmitter,@speedometer,@newyear,@enginevolume,@enginepower,@collected,@information)";
                SqlCommand cmd = new SqlCommand(script,conect);
                cmd.Parameters.AddWithValue("@brand", comboBox1.Text);
                cmd.Parameters.AddWithValue("@model", comboBox2.Text);
                cmd.Parameters.AddWithValue("@typeofban", comboBox3.Text);
                cmd.Parameters.AddWithValue("@march", textBox1.Text);
                cmd.Parameters.AddWithValue("@color", comboBox4.Text);
                cmd.Parameters.AddWithValue("@price", textBox2.Text);
                cmd.Parameters.AddWithValue("@theowner", comboBox5.Text);
                cmd.Parameters.AddWithValue("@fueltype", comboBox10.Text);
                cmd.Parameters.AddWithValue("@transmitter", comboBox8.Text);
                cmd.Parameters.AddWithValue("@speedometer", comboBox9.Text);
                cmd.Parameters.AddWithValue("@newyear", comboBox11.Text);
                cmd.Parameters.AddWithValue("@enginevolume", comboBox7.Text);
                cmd.Parameters.AddWithValue("@enginepower", textBox3.Text);
                cmd.Parameters.AddWithValue("@collected", comboBox6.Text);
                cmd.Parameters.AddWithValue("@information", richTextBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Melumatlar Elave edildi:");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conect.Close(); }
        }
        public void Insert2()
        {
            try
            {
                conect.Open();
                string script = @"INSERT INTO Contact(Name,City,Email,Phone)
                                VALUES(@name,@city,@email,@phone)";
                SqlCommand cmd = new SqlCommand(script,conect);
                cmd.Parameters.AddWithValue("@name", textBox5.Text);
                cmd.Parameters.AddWithValue("@city", comboBox14.Text);
                cmd.Parameters.AddWithValue("@email", textBox4.Text);
                cmd.Parameters.AddWithValue("@phone", maskedTextBox1.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
            finally { conect.Close(); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Insert1();
            Insert2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
