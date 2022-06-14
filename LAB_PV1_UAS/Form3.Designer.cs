/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 6/10/2022
 * Time: 8:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LAB_PV1_UAS
{
	partial class Form3
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
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.TextBox tanggallahir;
		private System.Windows.Forms.TextBox email;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Button loginmasuk;
		
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
			this.nama = new System.Windows.Forms.TextBox();
			this.tanggallahir = new System.Windows.Forms.TextBox();
			this.email = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.loginmasuk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1030, 82);
			this.label1.TabIndex = 0;
			this.label1.Text = "please login first";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Chocolate;
			this.label2.Location = new System.Drawing.Point(14, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(174, 56);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Chocolate;
			this.label3.Location = new System.Drawing.Point(14, 244);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(174, 56);
			this.label3.TabIndex = 3;
			this.label3.Text = "Date of Birth";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Chocolate;
			this.label4.Location = new System.Drawing.Point(14, 336);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(174, 56);
			this.label4.TabIndex = 4;
			this.label4.Text = "Email";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Chocolate;
			this.label5.Location = new System.Drawing.Point(14, 430);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(174, 56);
			this.label5.TabIndex = 5;
			this.label5.Text = "Password";
			// 
			// nama
			// 
			this.nama.Location = new System.Drawing.Point(205, 148);
			this.nama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(461, 26);
			this.nama.TabIndex = 6;
			// 
			// tanggallahir
			// 
			this.tanggallahir.Location = new System.Drawing.Point(205, 249);
			this.tanggallahir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tanggallahir.Name = "tanggallahir";
			this.tanggallahir.Size = new System.Drawing.Size(461, 26);
			this.tanggallahir.TabIndex = 7;
			// 
			// email
			// 
			this.email.Location = new System.Drawing.Point(205, 341);
			this.email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(461, 26);
			this.email.TabIndex = 8;
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(205, 435);
			this.password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(461, 26);
			this.password.TabIndex = 9;
			// 
			// loginmasuk
			// 
			this.loginmasuk.BackColor = System.Drawing.Color.Moccasin;
			this.loginmasuk.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginmasuk.Location = new System.Drawing.Point(704, 620);
			this.loginmasuk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.loginmasuk.Name = "loginmasuk";
			this.loginmasuk.Size = new System.Drawing.Size(266, 115);
			this.loginmasuk.TabIndex = 10;
			this.loginmasuk.Text = "Next Page ";
			this.loginmasuk.UseVisualStyleBackColor = false;
			this.loginmasuk.Click += new System.EventHandler(this.LoginmasukClick);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(1058, 808);
			this.Controls.Add(this.loginmasuk);
			this.Controls.Add(this.password);
			this.Controls.Add(this.email);
			this.Controls.Add(this.tanggallahir);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form3";
			this.Text = "Form3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
