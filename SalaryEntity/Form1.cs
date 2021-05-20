using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SalaryEntity
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        public Form1()
        {

            InitializeComponent();

            nameField.Text = "Имя Фамилия";
            nameField.ForeColor = Color.Black;

            dayField.Text = "Количество дней";
            dayField.ForeColor = Color.Black;

            textBox1.Text = "Имя Фамилия";
            textBox1.ForeColor = Color.Black;

            textBox2.Text = "Должность";
            textBox2.ForeColor = Color.Black;

            textBox3.Text = "Зарплата";
            textBox3.ForeColor = Color.Black;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {


        }

        private void nameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.dBDataSet.Workers);
            //DbBuild.DbCraft(); // создание базы данных
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);

            sqlConnection.Open();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                "INSERT INTO Workers (Name, ProfessionName, SalaryBlack) VALUES (@Name, @ProfessionName, @SalaryBlack)",
                sqlConnection);
            command.Parameters.AddWithValue("Name", textBox1.Text);
            command.Parameters.AddWithValue("ProfessionName", textBox2.Text);
            command.Parameters.AddWithValue("SalaryBlack", textBox3.Text);

            command.ExecuteNonQuery().ToString();
            
            MessageBox.Show("Добавлено");
            
        }
        
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void nameField_Enter(object sender, EventArgs e)
        {
            if (nameField.Text == "Имя Фамилия")
            nameField.Text = "";
            nameField.ForeColor = Color.Black;
        }

        private void nameField_Leave(object sender, EventArgs e)
        {
            if (nameField.Text == "")
                nameField.Text = "Имя Фамилия";
                nameField.ForeColor = Color.Black;
        }

        private void dayField_Enter(object sender, EventArgs e)
        {
            if (dayField.Text == "Количество дней")
                dayField.Text = "";
            dayField.ForeColor = Color.Black;
        }

        private void dayField_Leave(object sender, EventArgs e)
        {
            if (dayField.Text == "")
                dayField.Text = "Количество дней";
            dayField.ForeColor = Color.Black;
        }

        private void ButtonEnter_Click_1(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand(
                $"SELECT * FROM Workers WHERE Name = N'{nameField.Text}'",

            sqlConnection);
            SqlDataReader reader = command1.ExecuteReader();
            
            while (reader.Read())
        {
                double percent = (int)(reader.GetValue(3)) / 100 * 13;
                //var sum = reader.GetValue(3);
                //sum = (int)sum / 21 * int.Parse(dayField.Text);
                double salary = ((int)(reader.GetValue(3)) - (percent)) / 21 * int.Parse(dayField.Text);

                MessageBox.Show($"Ваша должность {reader.GetValue(2)},Ваша зарплата { (int)salary}");
        }
            reader.Close();

        }

        private void nameField_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Имя Фамилия")
                textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "Имя Фамилия";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Должность")
                textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                textBox2.Text = "Должность";
            textBox2.ForeColor = Color.Black;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Зарплата")
                textBox3.Text = "";
            textBox3.ForeColor = Color.Black;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
                textBox3.Text = "Зарплата";
            textBox3.ForeColor = Color.Black;
        }

        /*показ базы данных по кнопке
         * 
          private void Select_Click(object sender, EventArgs e)
        {

            SqlDataAdapter adapter = new SqlDataAdapter(
                 "SELECT * FROM Workers", sqlConnection);

             DataSet ds = new DataSet();

             adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];            
        }*/

    }
}