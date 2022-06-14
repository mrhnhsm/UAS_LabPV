/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 6/10/2022
 * Time: 8:15 PM
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
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		public Form3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void login()
		{
			if(nama.Text==""||tanggallahir.Text==""||email.Text==""||password.Text=="")
			{
				MessageBox.Show("Data Harus Diisi");
			}
			else{
			Form2 formhome = new Form2();
				formhome.Show();
			}
				
		}
		void LoginmasukClick(object sender, EventArgs e)
		{
			login();
		}
	}
}
