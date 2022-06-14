/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 6/10/2022
 * Time: 2:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LAB_PV1_UAS
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private int Count=0;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void NewToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form2 frmChild = new Form2();
			frmChild.MdiParent = this;
			frmChild.Show();
			frmChild.Text += "ChildForm #" + Count.ToString();
			Count++ ;
		}
		
		void CascadeToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}
		void HorizontalToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}
		void VerticalToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}
		void ArrangeToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
		void LoginToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form3 frmChild = new Form3();
			frmChild.MdiParent = this;
			frmChild.Show();
			frmChild.Text += "ChildForm #" + Count.ToString();
			Count++ ;
		}
		void CheckTicketToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form4 frmChild = new Form4();
			frmChild.MdiParent = this;
			frmChild.Show(); 
			frmChild.Text += "ChildForm #" + Count.ToString();
			Count++;
		}
	}
}
