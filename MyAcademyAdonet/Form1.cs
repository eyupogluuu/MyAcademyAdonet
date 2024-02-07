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

namespace MyAcademyAdonet
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand komut = new SqlCommand("Update  projects set tittle=@p1,descreption=@p2,projectCategory=@p3,completeDay=@p4,price=@p5) where projectsID=@p6", connection);
			komut.Parameters.AddWithValue("@p1", txtprobaslik.Text);
			komut.Parameters.AddWithValue("@p2", richTextdetaylar.Text);
			komut.Parameters.AddWithValue("@p3", combokategori.Text);
			komut.Parameters.AddWithValue("@p4", txtoran.Text);
			komut.Parameters.AddWithValue("@p5", txtfiyat.Text);
			komut.Parameters.AddWithValue("@p6", txtid.Text);
			komut.ExecuteNonQuery();
			connection.Close();
			MessageBox.Show("Proje Bilgisi Başarıyla Güncellendi");
		}
		SqlConnection connection = new SqlConnection("Server=DESKTOP-2PU1K7L\\SQLEXPRESS; initial catalog=myPortfolioDB;integrated security=true");
		private void btnliste_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand komut = new SqlCommand("Select * from Projects", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(komut);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			connection.Close();
		}

		private void btnekle_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand komut = new SqlCommand("insert into projects (tittle,descreption,projectCategory,completeDay,price) values (@p1,@p2,@p3,@p4,@p5)", connection);
			komut.Parameters.AddWithValue("@p1", txtprobaslik.Text);
			komut.Parameters.AddWithValue("@p2", richTextdetaylar.Text);
			komut.Parameters.AddWithValue("@p3", combokategori.Text);
			komut.Parameters.AddWithValue("@p4", txtoran.Text);
			komut.Parameters.AddWithValue("@p5", txtfiyat.Text);
			komut.ExecuteNonQuery();
			connection.Close();
			MessageBox.Show("Proje Bilgisi Başarıyla Eklendi");
		}

		private void btnsil_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand komut = new SqlCommand("delete from projects where projectsID=@p1", connection);
			komut.Parameters.AddWithValue("@p1", txtid.Text);
			komut.ExecuteNonQuery();
			connection.Close();
			MessageBox.Show("Proje Bilgisi Başarıyla Silindi");
		}

		private void btngetir_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand komut = new SqlCommand("Select * from projects where tittle=@p1", connection);
			komut.Parameters.AddWithValue("@p1", txtprobaslik.Text);
			SqlDataAdapter adapter = new SqlDataAdapter(komut);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			connection.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand komut = new SqlCommand("Select * From Category", connection);
			combokategori.DisplayMember="categoryName";
			combokategori.ValueMember="categoryID";
			SqlDataAdapter adapter = new SqlDataAdapter(komut);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			combokategori.DataSource= dataTable; 
			connection.Close();
		}
	}
}
