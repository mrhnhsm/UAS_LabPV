/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 6/14/2022
 * Time: 8:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB_PV1_UAS
{
	/// <summary>
	/// Description of Form4.
	/// </summary>
	public partial class Form4 : Form
	{
		public Form4()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			if (progressBar1.Value ==100)
			{
				timer1.Enabled = false;
				Form_print formhome = new Form_print();
				formhome.Show();
				
			}
			else{
				progressBar1.Value +=2;
			}
		}
	}
}
