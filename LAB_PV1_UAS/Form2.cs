/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 6/10/2022
 * Time: 2:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace LAB_PV1_UAS
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = tiket; Uid= root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			co.Open();
			datacombobox();
			Bacadata();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void datacombobox()
		{
			gender.Items.Add("Laki-Laki");
			gender.Items.Add("Perempuan");
			
			jenistiket.Items.Add("Ekonomi");
			jenistiket.Items.Add("Super Class");
			jenistiket.Items.Add("VVIP");
			
			
		}
		
		public void Bacadata(){
			try{
				mycommand.Connection=co;
				myadapter.SelectCommand=mycommand;
				mycommand.CommandText="select * from data_customer";
				DataSet ds = new DataSet();
				if(myadapter.Fill(ds,"data_customer")>0){
					data.DataSource = ds;
					data.DataMember = "data_customer";
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		void UmurKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		void GenderKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		void JenistiketKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		void BanyakKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		public void bersihkanData(){
			nama.Text="";
			umur.Text="";
			gender.Text="";
			jenistiket.Text="";
			banyak.Text="";
		}
		
		
		public void tambahkandata()
		{
			string namapembeli = nama.Text;
			int umurpembeli = int.Parse(umur.Text);
			string jeniskelamin = gender.Text;
			string jenis = jenistiket.Text;
			int banyaktiket = int.Parse(banyak.Text);
			
			co.Open();
			try
			{
				mycommand.Connection=co;
				mycommand.CommandText="insert into data_customer values ('"+namapembeli+"','"+umurpembeli+"','"+jeniskelamin+"','"+jenis+"','"+banyaktiket+"')";
				myadapter.SelectCommand=mycommand;
				if(mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data Sukses Dimasukkan");
					Bacadata();
					bersihkanData();
					Form4 formhome = new Form4();
					formhome.Show();
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
			}
		
		public void hapus_data(){
			try{
				co.Open();
				mycommand.Connection=co;
				mycommand.CommandText="delete from data_customer where nama='"+nama.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data Berhasil Dihapus");
						Bacadata();
						bersihkanData();
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void update_data()
		{
			string namapembeli = nama.Text;
			int umurpembeli = int.Parse(umur.Text);
			string jeniskelamin = gender.Text;
			string jenis = jenistiket.Text;
			int banyaktiket = int.Parse(banyak.Text);
			
			try{
				co.Open();
				mycommand.Connection=co;
				mycommand.CommandText="update data_customer set nama='"+namapembeli+"',umur='"+umurpembeli+"',gender='"+jeniskelamin+"',jenistiket='"+jenis+"',banyaktiket='"+banyaktiket+"' where nama='"+namapembeli+"'";
				myadapter.SelectCommand = mycommand;
				if(mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data  berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					Bacadata();
					bersihkanData();
					Form4 formhome = new Form4();
					formhome.Show();
				}
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
			
		}
		void DataCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			nama.Text=data.Rows[e.RowIndex].Cells[0].Value.ToString();
			umur.Text=data.Rows[e.RowIndex].Cells[1].Value.ToString();
			gender.Text=data.Rows[e.RowIndex].Cells[2].Value.ToString();
			jenistiket.Text=data.Rows[e.RowIndex].Cells[3].Value.ToString();
			banyak.Text=data.Rows[e.RowIndex].Cells[4].Value.ToString();
		}
		void SavedataClick(object sender, EventArgs e)
		{
			tambahkandata();
		}
		void HapusdataClick(object sender, EventArgs e)
		{
			hapus_data();
		}
		void UpdatedataClick(object sender, EventArgs e)
		{
			update_data();
		}
		
		
		
		

		
		
			
		}
	
	}
