/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2016/5/29
 * Time: 20:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace test
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.Text = System.Configuration.ConfigurationSettings.AppSettings["login_caption"];
			label1.Text = System.Configuration.ConfigurationSettings.AppSettings["login_title"];
			string dbname = System.Configuration.ConfigurationSettings.AppSettings["db_file"];
			
			string connectString = string.Empty;
			bool file_exists_flag = true;
			
			if(!File.Exists(dbname))
				file_exists_flag = false;
			
			connectString = @"Data Source=" + dbname + ";Pooling=true;FailIfMissing=false";
			conn = new SQLiteConnection(connectString);
			conn.Open();
				
			if(!file_exists_flag)
				init_database();
		}
		
		void Login_btnClick(object sender, System.EventArgs e)
		{
			try{
				SQLiteCommand cmd = conn.CreateCommand();
				cmd.CommandText = "SELECT rowid FROM manager WHERE uname='"+uname.Text.Trim()+"' AND upass='"+upass.Text.Trim()+"'";
				SQLiteDataReader reader = cmd.ExecuteReader();
				if(reader.HasRows){
					reader.Close();
					reader.Dispose();
					cmd.Dispose();
					
					this.Hide();
					Form1 fm1 = new Form1();
					fm1.ShowDialog();
				}else{
					MessageBox.Show("请输入正确的用户名和密码。");
				}
			}catch(System.Exception ex){
				Console.WriteLine(ex.ToString());
			}
		}
		void init_database()
		{
			try{
				SQLiteCommand cmd = conn.CreateCommand();
				cmd.CommandText = "CREATE TABLE main (name VARCHAR(100) NOT NULL,model VARCHAR(100),nums INTEGER,source VARCHAR(100),ctime VARCHAR(100),collection VARCHAR(100),comment VARCHAR(255))";//主表
				cmd.ExecuteNonQuery();
				cmd.CommandText = "CREATE TABLE history (udep VARCHAR(100),uname VARCHAR(100),main_id INTEGER NOT NULL,nums INTEGER,ctime VARCHAR(100),flag INTEGER(1) NOT NULL DEFAULT(0))";//操作记录表
				cmd.ExecuteNonQuery();
				cmd.CommandText = "CREATE TABLE manager (uname varchar(20),upass varchar(20))";//管理员表
				cmd.ExecuteNonQuery();
				cmd.CommandText = "CREATE INDEX im0 ON main (name,model)";//索引
				cmd.ExecuteNonQuery();
				cmd.CommandText = "CREATE INDEX ih0 ON history (udep,uname)";//索引
				cmd.ExecuteNonQuery();
				cmd.CommandText = "INSERT INTO manager (uname,upass) VALUES ('admin','85099201')";//默认用户名及密码
				cmd.ExecuteNonQuery();
			
				cmd.Dispose();
			}catch(Exception ex){
				Console.WriteLine(ex.ToString());
				MessageBox.Show("初始化数据库出错");
			}
		}
	}
}
