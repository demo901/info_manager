/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2016/5/29
 * Time: 20:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace test
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.uname = new System.Windows.Forms.TextBox();
			this.upass = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.login_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("幼圆", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(121, 53);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(486, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "东北师范大学图书馆系统部";
			// 
			// uname
			// 
			this.uname.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.uname.Location = new System.Drawing.Point(334, 146);
			this.uname.Margin = new System.Windows.Forms.Padding(5);
			this.uname.Name = "uname";
			this.uname.Size = new System.Drawing.Size(184, 39);
			this.uname.TabIndex = 1;
			this.uname.Text = "admin";
			// 
			// upass
			// 
			this.upass.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.upass.Location = new System.Drawing.Point(334, 236);
			this.upass.Margin = new System.Windows.Forms.Padding(5);
			this.upass.Name = "upass";
			this.upass.PasswordChar = '*';
			this.upass.Size = new System.Drawing.Size(184, 39);
			this.upass.TabIndex = 2;
			this.upass.Text = "85099201";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(158, 149);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(166, 39);
			this.label2.TabIndex = 3;
			this.label2.Text = "用户名称：";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(158, 241);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(166, 34);
			this.label3.TabIndex = 4;
			this.label3.Text = "输入密码：";
			// 
			// login_btn
			// 
			this.login_btn.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.login_btn.Location = new System.Drawing.Point(238, 326);
			this.login_btn.Margin = new System.Windows.Forms.Padding(5);
			this.login_btn.Name = "login_btn";
			this.login_btn.Size = new System.Drawing.Size(186, 48);
			this.login_btn.TabIndex = 5;
			this.login_btn.Text = "登录系统";
			this.login_btn.UseVisualStyleBackColor = true;
			this.login_btn.Click += new System.EventHandler(this.Login_btnClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(685, 426);
			this.Controls.Add(this.login_btn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.upass);
			this.Controls.Add(this.uname);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "登录系统";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button login_btn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox upass;
		private System.Windows.Forms.TextBox uname;
		private System.Windows.Forms.Label label1;
		private System.Data.SQLite.SQLiteConnection conn;
	}
}
