/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 6/10/2022
 * Time: 2:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LAB_PV1_UAS
{
	partial class Form2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button updatedata;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.TextBox umur;
		private System.Windows.Forms.ComboBox gender;
		private System.Windows.Forms.ComboBox jenistiket;
		private System.Windows.Forms.TextBox banyak;
		private System.Windows.Forms.Button savedata;
		private System.Windows.Forms.Button hapusdata;
		private System.Windows.Forms.DataGridView data;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.updatedata = new System.Windows.Forms.Button();
			this.nama = new System.Windows.Forms.TextBox();
			this.umur = new System.Windows.Forms.TextBox();
			this.gender = new System.Windows.Forms.ComboBox();
			this.jenistiket = new System.Windows.Forms.ComboBox();
			this.banyak = new System.Windows.Forms.TextBox();
			this.savedata = new System.Windows.Forms.Button();
			this.hapusdata = new System.Windows.Forms.Button();
			this.data = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(838, 76);
			this.label1.TabIndex = 0;
			this.label1.Text = "please fill in the data to buy a ticket";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(14, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(305, 71);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label3.Location = new System.Drawing.Point(14, 199);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(305, 71);
			this.label3.TabIndex = 2;
			this.label3.Text = "Age";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label4.Location = new System.Drawing.Point(14, 272);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(305, 71);
			this.label4.TabIndex = 3;
			this.label4.Text = "Gender";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label5.Location = new System.Drawing.Point(14, 344);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(305, 71);
			this.label5.TabIndex = 4;
			this.label5.Text = "Ticket Type";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label6.Location = new System.Drawing.Point(14, 415);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(305, 71);
			this.label6.TabIndex = 5;
			this.label6.Text = "Many Tickets Booked";
			// 
			// updatedata
			// 
			this.updatedata.BackColor = System.Drawing.Color.SkyBlue;
			this.updatedata.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updatedata.Location = new System.Drawing.Point(677, 415);
			this.updatedata.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.updatedata.Name = "updatedata";
			this.updatedata.Size = new System.Drawing.Size(174, 51);
			this.updatedata.TabIndex = 14;
			this.updatedata.Text = "Update Data";
			this.updatedata.UseVisualStyleBackColor = false;
			this.updatedata.Click += new System.EventHandler(this.UpdatedataClick);
			// 
			// nama
			// 
			this.nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nama.Location = new System.Drawing.Point(325, 140);
			this.nama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(326, 26);
			this.nama.TabIndex = 7;
			// 
			// umur
			// 
			this.umur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.umur.Location = new System.Drawing.Point(325, 210);
			this.umur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.umur.Name = "umur";
			this.umur.Size = new System.Drawing.Size(326, 26);
			this.umur.TabIndex = 8;
			this.umur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UmurKeyPress);
			// 
			// gender
			// 
			this.gender.FormattingEnabled = true;
			this.gender.Location = new System.Drawing.Point(325, 284);
			this.gender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gender.Name = "gender";
			this.gender.Size = new System.Drawing.Size(326, 28);
			this.gender.TabIndex = 9;
			this.gender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GenderKeyPress);
			// 
			// jenistiket
			// 
			this.jenistiket.FormattingEnabled = true;
			this.jenistiket.Location = new System.Drawing.Point(325, 355);
			this.jenistiket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.jenistiket.Name = "jenistiket";
			this.jenistiket.Size = new System.Drawing.Size(326, 28);
			this.jenistiket.TabIndex = 10;
			this.jenistiket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JenistiketKeyPress);
			// 
			// banyak
			// 
			this.banyak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.banyak.Location = new System.Drawing.Point(325, 426);
			this.banyak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.banyak.Name = "banyak";
			this.banyak.Size = new System.Drawing.Size(326, 26);
			this.banyak.TabIndex = 11;
			this.banyak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BanyakKeyPress);
			// 
			// savedata
			// 
			this.savedata.BackColor = System.Drawing.Color.SkyBlue;
			this.savedata.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.savedata.Location = new System.Drawing.Point(677, 128);
			this.savedata.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.savedata.Name = "savedata";
			this.savedata.Size = new System.Drawing.Size(174, 51);
			this.savedata.TabIndex = 12;
			this.savedata.Text = "Save Data";
			this.savedata.UseVisualStyleBackColor = false;
			this.savedata.Click += new System.EventHandler(this.SavedataClick);
			// 
			// hapusdata
			// 
			this.hapusdata.BackColor = System.Drawing.Color.SkyBlue;
			this.hapusdata.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hapusdata.Location = new System.Drawing.Point(677, 272);
			this.hapusdata.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.hapusdata.Name = "hapusdata";
			this.hapusdata.Size = new System.Drawing.Size(174, 51);
			this.hapusdata.TabIndex = 13;
			this.hapusdata.Text = "Delete Data";
			this.hapusdata.UseVisualStyleBackColor = false;
			this.hapusdata.Click += new System.EventHandler(this.HapusdataClick);
			// 
			// data
			// 
			this.data.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data.Location = new System.Drawing.Point(14, 490);
			this.data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.data.Name = "data";
			this.data.RowTemplate.Height = 24;
			this.data.Size = new System.Drawing.Size(838, 312);
			this.data.TabIndex = 6;
			this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataCellContentClick);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(866, 811);
			this.Controls.Add(this.updatedata);
			this.Controls.Add(this.hapusdata);
			this.Controls.Add(this.savedata);
			this.Controls.Add(this.banyak);
			this.Controls.Add(this.jenistiket);
			this.Controls.Add(this.gender);
			this.Controls.Add(this.umur);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.data);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form2";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
