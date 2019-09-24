using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlOrnekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection("Server=.; Database=Northwind; UID=sa; PWD=123");
        private void Form1_Load(object sender, EventArgs e)
        {
            cnn.Open();
            string sql = "Select EmployeeID from Employees";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //cbxIdSec.DataSource = dt;
            //cbxIdSec.DisplayMember = "EmployeeID";



            cnn.Close();

            //////////////////////////////////////////////////////////
            comboBox1.Items.Add("Argentina");
            comboBox1.Items.Add("Austria");
            comboBox1.Items.Add("Belgium");
            comboBox1.Items.Add("Brazil");
            comboBox1.Items.Add("Canada");
            comboBox1.Items.Add("Denmark");
            comboBox1.Items.Add("Finland");
            comboBox1.Items.Add("France");
            comboBox1.Items.Add("Germany");
            comboBox1.Items.Add("Ireland");
            comboBox1.Items.Add("Italy");
            comboBox1.Items.Add("Mexico");
            comboBox1.Items.Add("Norway");
            comboBox1.Items.Add("Poland");
            comboBox1.Items.Add("Portugal");
            comboBox1.Items.Add("Spain");
            comboBox1.Items.Add("Sweden");
            comboBox1.Items.Add("Switzerland");
            comboBox1.Items.Add("UK");
            comboBox1.Items.Add("USA");
            comboBox1.Items.Add("Venezuela");

        }

        //Select sorgusu için örnek
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            cnn.Open();

            //Ülkelere göre sipariş sayılarını sayar
            string sql = "Select Count(Country) from Customers c INNER JOIN Orders o on c.CustomerID = o.CustomerID where c.Country = @country";

            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@country", comboBox1.SelectedItem.ToString());

            int count = (int)cmd.ExecuteScalar();


            textBox1.Text = count.ToString();



            cnn.Close();
        }

        //Ekleme
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server=.; Database=Northwind; UID=sa; PWD=123");
            cnn.Open();

            string sql = "Insert into Employees (FirstName,LastName,Title,Country) VALUES(@fname,@lname,@title,@country)";

            SqlCommand cmd = new SqlCommand(sql, cnn);

            cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
            cmd.Parameters.AddWithValue("@title", txtEmployeeTitle.Text);
            cmd.Parameters.AddWithValue("@country", txtCountry.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt başarıyla eklenmiştir");
            cnn.Close();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string sqlUp = "Update Employees SET FirstName = @ad where EmployeeID=@id";
            SqlCommand cmd = new SqlCommand(sqlUp, cnn);

            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@ad", txtFirstName.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Kayıt güncellendi");
            cnn.Close();

        }

        private void cbxIdSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cnn.Open();
            ////Id'ye göre çekme
            //string sql2 = "SELECT FirstName,LastName,Title FROM Employees WHERE EmployeeID = " + cbxIdSec.SelectedValue;

            //SqlCommand cmd2 = new SqlCommand(sql2, cnn);
            //SqlDataReader reader = cmd2.ExecuteReader();

            //if (reader.Read())
            //{
            //    txtFirstName.Text = reader["FirstName"].ToString();
            //    txtLastName.Text = reader["LastName"].ToString();
            //    txtEmployeeTitle.Text = reader["Title"].ToString();
            //    txtCountry.Text = reader["LastName"].ToString();
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server=.; Database=Northwind; UID=sa; PWD=123");
            cnn.Open();
            string sqlUp = "DELETE FROM Employees where EmployeeID=@eid";
            SqlCommand cmd = new SqlCommand(sqlUp, cnn);

            cmd.Parameters.AddWithValue("@eid", Convert.ToInt32(txtId.Text));
            cmd.ExecuteNonQuery();

            MessageBox.Show("Kayıt silindi");
            cnn.Close();
        }

        private void btnCalisanlariGetir_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server=.; Database=Northwind; UID=sa; PWD=123");
            cnn.Open();
            string sql = "SELECT FirstName FROM Employees";

            SqlCommand cmd = new SqlCommand(sql, cnn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string ad = reader["FirstName"].ToString();
                listBox1.Items.Add(ad);
            }
        }

        //Update
    }
}
