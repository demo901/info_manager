/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2016/5/29
 * Time: 21:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;

namespace test
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		private SQLiteConnection connection = null;
		private Hashtable ht_row = new Hashtable();//被修改的记录id
		private int popFlag = 1;//弹出右键,1代表主表及按名称搜索结果；2代表按领用人和部门搜索
		//private int preTab = 0;//当前tabID
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void Form1_Load(object sender, EventArgs e)  
		{
			dgv0.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;//列宽不自动调整,手工添加列
			dgv0.AlternatingRowsDefaultCellStyle.BackColor = Color.LemonChiffon;//奇数行背景色
			dgv0.BackgroundColor = Color.White;//控件背景色
			dgv0.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//列标题居中显示
			dgv0.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//单元格内容居中显示
			dgv0.AutoGenerateColumns = false;//不自动创建列
			
			this.Text = System.Configuration.ConfigurationSettings.AppSettings["main_title"];
			pictureBox1.LoadAsync(System.Configuration.ConfigurationSettings.AppSettings["logo_picture"]);
			
  			string dbname = System.Configuration.ConfigurationSettings.AppSettings["db_file"];
			connection = new SQLiteConnection(@"Data Source=" + dbname + ";Pooling=true;FailIfMissing=false");
			connection.Open();
			
			load_main_table();//显示默认表格
			search_key.SelectedIndex = 0;
			popFlag = 1;
			//preTab = 0;
		}
		void Form1FormClosing(object sender, FormClosingEventArgs e)
		{
			if(ht_row.Count > 0){
				if(MessageBox.Show("数据尚未保存，是否退出","提示",MessageBoxButtons.YesNo)==DialogResult.No){
					e.Cancel = true;
					return;
				}else{
					e.Cancel = false;
				}
			}
			try{
				connection.Close();
				connection.Dispose();
				connection = null;
			}catch(Exception ex){
				Console.WriteLine(ex.ToString());
			}
			System.Environment.Exit(0);
		}
		void Exit_btnClick(object sender, EventArgs e)
		{
			if(ht_row.Count > 0){
				if(MessageBox.Show("数据尚未保存，是否退出","提示",MessageBoxButtons.YesNo)==DialogResult.No)
					return;
			}
			try{
				connection.Close();
				connection.Dispose();
				connection = null;
			}catch(Exception ex){
				Console.WriteLine(ex.ToString());
			}
			System.Environment.Exit(0);
		}
		void TabControl1SelectedIndexChanged(object sender, EventArgs e)
		{
			switch(this.tabControl1.SelectedIndex){
				case 0:
					load_main_table();
					//preTab = 0;
					break;
				case 1:
					search_btn2.PerformClick();
					//preTab = 1;
					break;
				case 2:
					//preTab = 2;
					break;
				case 3:
					//preTab = 3;
					break;
				case 4:
					//preTab = 4;
					break;
			}
		}
		//显示主表格
		void load_main_table(){
			if(ht_row.Count > 0){
				if(MessageBox.Show("数据尚未保存，是否刷新表格？","提示",MessageBoxButtons.YesNo)==DialogResult.No){
					return;
				}
			}
			popFlag = 1;
			set_dgv0_format();
			
			try{
				SQLiteCommand cmd = connection.CreateCommand();
				SQLiteDataReader reader;
				cmd.CommandText = "select rowid,name,model,nums,source,ctime,collection,comment from main";
				reader = cmd.ExecuteReader();
				while(reader.Read()){
					dgv0.Rows.Add(new object[] {
		              	reader[0].ToString(),
		              	reader[1].ToString(),
		              	reader[2].ToString(),
		              	reader[3].ToString(),
		              	reader[4].ToString(),
		              	reader[5].ToString(),
		              	reader[6].ToString(),
		              	reader[7].ToString()
					});
				}
				reader.Close();
				reader.Dispose();
				cmd.Dispose();
			}catch(Exception ex){
				MessageBox.Show("读取main数据表出错" + ex.ToString());
			}
		}
		//设置表格样式
		void set_dgv0_format(){
			dgv0.Rows.Clear();
			dgv0.Columns.Clear();
			ht_row.Clear();
			
			dgv0.Columns.Add("sid","序号");
			dgv0.Columns.Add("name","物品名称");
			dgv0.Columns.Add("model","规格型号");
			dgv0.Columns.Add("nums","数量");
			
			if(popFlag == 1){
				dgv0.Columns.Add("source","来源");
				dgv0.Columns.Add("ctime","接收时间");
				dgv0.Columns.Add("collection","所在地");
				dgv0.Columns.Add("comment","备注");
				dgv0.ReadOnly = false;
				dgv0.Columns[0].ReadOnly = true;
			}
			if(popFlag == 2){
				dgv0.Columns.Add("udep","部门");//4
				dgv0.Columns.Add("user","领取人");//5
				dgv0.Columns.Add("ctime","时间");//6
				dgv0.Columns.Add("flag","操作");//7
				dgv0.ReadOnly = true;
			}
			dgv0.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv0.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv0.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv0.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv0.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv0.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv0.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		}
		//第二个页面搜索功能
		void Search_btn2Click(object sender, EventArgs e)
		{
			try{
				SQLiteCommand cmd = connection.CreateCommand();
				SQLiteDataReader reader = null;
				
				dgv2.Rows.Clear();
				dgv2.Columns.Clear();

				dgv2.Columns.Add("sid","序号");
				dgv2.Columns.Add("name","名称");
				dgv2.Columns.Add("model","型号");
				dgv2.Columns.Add("udep","部门");
				dgv2.Columns.Add("user","人员");
				dgv2.Columns.Add("nums","数量");
				dgv2.Columns.Add("ctime","时间");
				dgv2.Columns.Add("flag","操作");
				dgv2.ReadOnly = true;

				dgv2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				dgv2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				dgv2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				dgv2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				dgv2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				dgv2.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				dgv2.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				dgv2.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				
				string sql = "select a.rowid,b.name,b.model,a.nums,a.udep,a.uname,a.ctime,a.flag from history a,main b where a.main_id=b.rowid ";
				if(search_key2.Text.ToString().Equals("部门") || search_key2.Text.Equals("领取人")){
					if(search_txt2.Text.Trim().Length > 0){
						if(search_key2.Text.Equals("部门"))
							sql += "and a.udep like '%";
						else
							sql += "and a.uname like '%";
						sql += search_txt2.Text.Trim() + "%'";
					}
				}
				cmd.CommandText = sql;
				reader = cmd.ExecuteReader();
				while(reader.Read()){
					string flag = reader[7].ToString();
					if(flag.Equals("0"))
						flag = "领用";
					else
						flag = "归还";
					dgv2.Rows.Add(new object[] {
		              	reader[0].ToString(),
		              	reader[1].ToString(),
		              	reader[2].ToString(),
		              	reader[3].ToString(),
		              	reader[4].ToString(),
		              	reader[5].ToString(),
		              	reader[6].ToString(),
		              	flag
					});
				}
				reader.Close();
				reader.Dispose();
				cmd.Dispose();
			}catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		//第一个页面搜索功能
		void Search_btnClick(object sender, EventArgs e)
		{
			if(ht_row.Count > 0){
				if(MessageBox.Show("数据尚未保存，搜索结果会覆盖当前表格内容，是否继续？","提示",MessageBoxButtons.YesNo)==DialogResult.No){
					return;
				}
			}
			
			try{
				SQLiteCommand cmd = connection.CreateCommand();
				SQLiteDataReader reader = null;
				string sql = string.Empty;
				if(search_key.Text.ToString().Equals("物品名称") || search_key.Text.Equals("型号")){
					popFlag = 1;
					set_dgv0_format();
					sql = "select rowid,name,model,nums,source,ctime,collection,comment from main where ";
					if(search_key.Text.Equals("物品名称"))
						sql += "name like '%";
					else
						sql += "model like '%";
					sql += search_txt.Text.Trim() + "%'";
					cmd.CommandText = sql;
					reader = cmd.ExecuteReader();
					while(reader.Read()){
						dgv0.Rows.Add(new object[] {
			              	reader[0].ToString(),
			              	reader[1].ToString(),
			              	reader[2].ToString(),
			              	reader[3].ToString(),
			              	reader[4].ToString(),
			              	reader[5].ToString(),
			              	reader[6].ToString(),
			              	reader[7].ToString()
						});
					}
				}
				if(search_key.Text.ToString().Equals("部门") || search_key.Text.Equals("领取人")){
					popFlag = 2;
					set_dgv0_format();

					sql = "select a.rowid,b.name,b.model,a.nums,a.udep,a.uname,a.ctime,a.flag from history a,main b where a.main_id=b.rowid and ";
					if(search_key.Text.Equals("部门"))
						sql += "a.udep like '%";
					else
						sql += "a.uname like '%";
					sql += search_txt.Text.Trim() + "%'";
					cmd.CommandText = sql;
					reader = cmd.ExecuteReader();
					while(reader.Read()){
						string flag = reader[7].ToString();
						if(flag.Equals("0"))
							flag = "领用";
						else
							flag = "归还";
						dgv0.Rows.Add(new object[] {
			              	reader[0].ToString(),
			              	reader[1].ToString(),
			              	reader[2].ToString(),
			              	reader[3].ToString(),
			              	reader[4].ToString(),
			              	reader[5].ToString(),
			              	reader[6].ToString(),
			              	flag
						});
					}
				}
				reader.Close();
				reader.Dispose();
				cmd.Dispose();
			}catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		//存盘
		void Save_btnClick(object sender, EventArgs e)
		{
			if(ht_row.Count == 0)
				return;
			SQLiteCommand cmd = connection.CreateCommand();
			string sql = string.Empty;
			string flag = string.Empty;
			int rowid = 0;//数据库的rowid
			int rowindex = 0;//表格的行号
			string name = string.Empty;
			string model = string.Empty;
			string nums = string.Empty;
			string source = string.Empty;
			string ctime = string.Empty;
			string collection = string.Empty;
			string comment = string.Empty;
			string udep = string.Empty;
			string user = string.Empty;
			string loan = string.Empty;
			try{
				foreach (DictionaryEntry de in ht_row)
				{
					flag = de.Key.ToString().Substring(0,1);
					rowindex = int.Parse(de.Key.ToString().Substring(1));
					rowid = int.Parse(de.Value.ToString());
					if(flag.Equals("D")){//删除记录
						sql = "delete from main where rowid="+rowid;
						cmd.CommandText = sql;
						cmd.ExecuteNonQuery();
						continue;
					}
					if(dgv0.Rows[rowindex].Cells[1].Value != null)//1
						name = dgv0.Rows[rowindex].Cells[1].Value.ToString();
					else
						name = "";
					if(dgv0.Rows[rowindex].Cells[2].Value != null)//2
						model= dgv0.Rows[rowindex].Cells[2].Value.ToString();
					else
						model = "";
					if(dgv0.Rows[rowindex].Cells[3].Value != null)//3
						nums = dgv0.Rows[rowindex].Cells[3].Value.ToString();
					else
						nums = "0";
					if(dgv0.Rows[rowindex].Cells[4].Value != null)//4
						source = dgv0.Rows[rowindex].Cells[4].Value.ToString();
					else
						source = "";
					if(dgv0.Rows[rowindex].Cells[5].Value != null)
						ctime = dgv0.Rows[rowindex].Cells[5].Value.ToString();
					else
						ctime = "";
					if(dgv0.Rows[rowindex].Cells[6].Value != null)
						collection = dgv0.Rows[rowindex].Cells[6].Value.ToString();
					else
						collection = "";
					if(dgv0.Rows[rowindex].Cells[7].Value != null)
						comment = dgv0.Rows[rowindex].Cells[7].Value.ToString();
					else
						comment = "";
					if(flag.Equals("A")){//新增记录
						sql = "insert into main (name,model,nums,source,ctime,collection,comment) values ('"+name+"','"+model+"',"+nums+",'"+source+"','"+ctime+"','"+collection+"','"+comment+"')";
						cmd.CommandText = sql;
						cmd.ExecuteNonQuery();
						continue;
					}
					if(flag.Equals("E")){//修改记录
						sql = "update main set name='"+name+"',model='"+model+"',nums="+nums+",source='"+source+"',ctime='"+ctime+"',collection='"+collection+"',comment='"+comment+"' where rowid="+rowid;
						cmd.CommandText = sql;
						cmd.ExecuteNonQuery();
						continue;
					}
				}
			}catch(Exception ex){
				Console.WriteLine(ex.ToString());
				MessageBox.Show("存盘失败");
			}
			ht_row.Clear();
			load_main_table();
		}
		//弹出右键菜单
		void Dgv0CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
			    if (e.RowIndex >= 0)
			    {
			        //若行已是选中状态就不再进行设置
			        if (dgv0.Rows[e.RowIndex].Selected == false)
			        {
			            dgv0.ClearSelection();
			            dgv0.Rows[e.RowIndex].Selected = true;
			        }
			        //只选中一行时设置活动单元格
			        if (dgv0.SelectedRows.Count == 1)
			        {
			            dgv0.CurrentCell = dgv0.Rows[e.RowIndex].Cells[e.ColumnIndex];
			        }
			        //弹出主操作菜单
			        if(popFlag == 1)
			        	contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
			        //if(popFlag == 2)
			        //	contextMenuStrip2.Show(MousePosition.X, MousePosition.Y);
			    }
			}
		}
		//单元格内容改变时
		void Dgv0CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			int rowid = e.RowIndex;
			string id = string.Empty;
			try{
				id = this.dgv0.Rows[e.RowIndex].Cells[0].Value.ToString();
				if(!ht_row.Contains("E"+rowid.ToString())){
					ht_row.Add("E"+rowid.ToString(),id);
					//MessageBox.Show("E"+rowid.ToString());
				}else{
					ht_row["E"+rowid.ToString()] = id;
				}
			}catch(System.NullReferenceException e0){
				Console.WriteLine(e0.ToString());
				id = e.RowIndex.ToString();
				if(!ht_row.Contains("A"+rowid.ToString()))
					ht_row.Add("A"+rowid.ToString(),id);
				else
					ht_row["A"+rowid.ToString()] = id;
			}
		}
		//删除记录操作 -- 主表 -- 鼠标右键
		void Record_delete_menuClick(object sender, EventArgs e)
		{
			string rowid = this.dgv0.CurrentRow.Cells[0].RowIndex.ToString();
			string id = string.Empty;
			try{
				id = this.dgv0.CurrentRow.Cells[0].Value.ToString();
				if(!ht_row.Contains("D"+rowid))
					ht_row.Add("D"+rowid,id);
			}catch(NullReferenceException e0){
				Console.WriteLine(e0.ToString());
				id = this.dgv0.CurrentRow.Cells[0].RowIndex.ToString();
				if(!ht_row.Contains("N"+rowid))
					ht_row.Add("N"+rowid,id);
			}
		}
		//查看历史记录 -- 主表 -- 鼠标右键
		void Loan_return_menuClick(object sender, EventArgs e)
		{
			string id = string.Empty;
			try{
				id = this.dgv0.CurrentRow.Cells[0].Value.ToString();
			}catch(NullReferenceException e0){
				Console.WriteLine(e0.ToString());
				id = this.dgv0.CurrentRow.Cells[0].RowIndex.ToString();
			}
			Form2 fm = new Form2(int.Parse(id));
			fm.ShowDialog(this);
		}
		//修改密码
		void Change_pass_btnClick(object sender, EventArgs e)
		{
			string uname = txt3_yonghumingcheng.Text.Trim();
			string old_pass = txt3_yuanmima.Text.Trim();
			string new_pass1 = txt3_xinmima.Text.Trim();
			string new_pass2 = txt3_querenmima.Text.Trim();
			if(!new_pass1.Equals(new_pass2)){
				MessageBox.Show("两次输入的密码不一致，请重新输入。");
				return;
			}
			try{
				SQLiteCommand cmd = connection.CreateCommand();
				cmd.CommandText = "SELECT rowid FROM manager WHERE uname='"+uname+"' AND upass='"+old_pass+"'";
				SQLiteDataReader reader = cmd.ExecuteReader();
				if(!reader.HasRows){
					MessageBox.Show("请输入正确的用户名和密码。");
					reader.Close();
					reader.Dispose();
					cmd.Dispose();
					
					return;
				}
				reader.Close();
				
				cmd.CommandText = "UPDATE manager SET uname='"+uname+"',upass='"+new_pass1+"'";
				int c = cmd.ExecuteNonQuery();
				if(c == 1){
					MessageBox.Show("修改成功.");
				}else{
					MessageBox.Show("修改失败，请重试.");
				}
				reader.Dispose();
				cmd.Dispose();
			}catch(Exception ex){
				//MessageBox.Show(ex.ToString());
				ex.ToString();
			}
		}
		//外借部门下拉选择
		void Dep_loanDropDown(object sender, EventArgs e)
		{
			dep_loan.Items.Clear();
			string sql = "select distinct udep from history";
			try{
				SQLiteCommand cmd = connection.CreateCommand();
				cmd.CommandText = sql;
				SQLiteDataReader reader = cmd.ExecuteReader();
				while(reader.Read()){
					dep_loan.Items.Add(reader[0].ToString());
				}
				reader.Close();
				reader.Dispose();
				cmd.Dispose();
			}catch(Exception ex){
				//MessageBox.Show(ex.ToString());
				ex.ToString();
			}
		}
		//外借领用人下拉选择
		void User_loanDropDown(object sender, EventArgs e)
		{
			user_loan.Items.Clear();
			string sql = "select distinct uname from history where udep='"+dep_loan.Text.Trim()+"'";
			try{
				SQLiteCommand cmd = connection.CreateCommand();
				cmd.CommandText = sql;
				SQLiteDataReader reader = cmd.ExecuteReader();
				while(reader.Read()){
					user_loan.Items.Add(reader[0].ToString());
				}
				reader.Close();
				reader.Dispose();
				cmd.Dispose();
			}catch(Exception ex){
				//MessageBox.Show(ex.ToString());
				ex.ToString();
			}
		}
		//外借物品下拉选择
		void Name_loanDropDown(object sender, EventArgs e)
		{
			name_loan.Items.Clear();
			string sql = "select distinct name from main";
			try{
				SQLiteCommand cmd = connection.CreateCommand();
				cmd.CommandText = sql;
				SQLiteDataReader reader = cmd.ExecuteReader();
				while(reader.Read()){
					name_loan.Items.Add(reader[0].ToString());
				}
				reader.Close();
				reader.Dispose();
				cmd.Dispose();
			}catch(Exception ex){
				//MessageBox.Show(ex.ToString());
				ex.ToString();
			}
		}
		//外借物品型号下拉选择
		void Model_loanDropDown(object sender, EventArgs e)
		{
			model_loan.Items.Clear();
			string sql = "select distinct model from main where name='"+name_loan.Text.Trim()+"'";
			try{
				SQLiteCommand cmd = connection.CreateCommand();
				cmd.CommandText = sql;
				SQLiteDataReader reader = cmd.ExecuteReader();
				while(reader.Read()){
					model_loan.Items.Add(reader[0].ToString());
				}
				reader.Close();
				reader.Dispose();
				cmd.Dispose();
			}catch(Exception ex){
				//MessageBox.Show(ex.ToString());
				ex.ToString();
			}
		}
		//领用
		void Loan_btnClick(object sender, EventArgs e)
		{
			string udep = dep_loan.Text.Trim();
			string user = user_loan.Text.Trim();
			string name = name_loan.Text.Trim();
			string model= model_loan.Text.Trim();
			string nums = nums_loan.Text.Trim();
			string ctime = loan_time.Value.ToString();
			
			if(udep.Length == 0)
				return;
			if(user.Length == 0)
				return;
			if(name.Length == 0)
				return;
			//if(model.Length == 0)
			//	return;
			if(nums.Length == 0)
				return;
			
			string sql = "select rowid,nums from main where name='"+name+"' and model='"+model+"'";
			int rowid = 0;//物品id
			int cur_nums = 0;//库存数量
			try{
				SQLiteCommand cmd = connection.CreateCommand();
				cmd.CommandText = sql;
				SQLiteDataReader reader = cmd.ExecuteReader();
				if(reader.Read()){
					rowid = int.Parse(reader[0].ToString());
					cur_nums = int.Parse(reader[1].ToString());
				}
				reader.Close();
				reader.Dispose();
				if(rowid>0){
					if(cur_nums >= int.Parse(nums)){
						sql = "insert into history (udep,uname,main_id,nums,ctime,flag) values ('"+udep+"','"+user+"',"+rowid.ToString()+","+nums+",'"+ctime+"',0)";
						cmd.CommandText = sql;
						cmd.ExecuteNonQuery();
						sql = "update main set nums=nums-"+nums+" where rowid="+rowid.ToString();
						cmd.CommandText = sql;
						cmd.ExecuteNonQuery();
						MessageBox.Show("领用成功");
					}else{
						MessageBox.Show("库存物品数量不足，领取失败。");
					}
				}else{
					MessageBox.Show("未找到相关物品，请核实后重新操作");
				}
				cmd.Dispose();
			}catch(Exception ex){
				MessageBox.Show("【Debug】领用时出现系统错误");
				ex.ToString();
			}
		}
		//归还,部门下拉框
		void Dep_returnDropDown(object sender, EventArgs e)
		{
			dep_return.Items.Clear();
			user_return.Items.Clear();
			string sql = "select distinct udep from history";
			try{
				SQLiteCommand cmd = connection.CreateCommand();
				cmd.CommandText = sql;
				SQLiteDataReader reader = cmd.ExecuteReader();
				while(reader.Read()){
					dep_return.Items.Add(reader[0].ToString());
				}
				reader.Close();
				reader.Dispose();
				cmd.Dispose();
			}catch(Exception ex){
				//MessageBox.Show(ex.ToString());
				ex.ToString();
			}
		}
		//归还，人员下拉框
		void User_returnDropDown(object sender, EventArgs e)
		{
			user_return.Items.Clear();
			string sql = "select distinct uname from history where udep='"+dep_return.Text.Trim()+"'";
			try{
				SQLiteCommand cmd = connection.CreateCommand();
				cmd.CommandText = sql;
				SQLiteDataReader reader = cmd.ExecuteReader();
				while(reader.Read()){
					user_return.Items.Add(reader[0].ToString());
				}
				reader.Close();
				reader.Dispose();
				cmd.Dispose();
			}catch(Exception ex){
				//MessageBox.Show(ex.ToString());
				ex.ToString();
			}
		}
		//归还，物品名称下拉框
		void Name_returnDropDown(object sender, EventArgs e)
		{
			name_return.Items.Clear();
			string sql = "select distinct name from main";
			try{
				SQLiteCommand cmd = connection.CreateCommand();
				cmd.CommandText = sql;
				SQLiteDataReader reader = cmd.ExecuteReader();
				while(reader.Read()){
					name_return.Items.Add(reader[0].ToString());
				}
				reader.Close();
				reader.Dispose();
				cmd.Dispose();
			}catch(Exception ex){
				//MessageBox.Show(ex.ToString());
				ex.ToString();
			}
		}
		//归还，型号下拉框
		void Model_returnDropDown(object sender, EventArgs e)
		{
			model_return.Items.Clear();
			string sql = "select distinct model from main where name='"+name_return.Text.Trim()+"'";
			try{
				SQLiteCommand cmd = connection.CreateCommand();
				cmd.CommandText = sql;
				SQLiteDataReader reader = cmd.ExecuteReader();
				while(reader.Read()){
					model_return.Items.Add(reader[0].ToString());
				}
				reader.Close();
				reader.Dispose();
				cmd.Dispose();
			}catch(Exception ex){
				MessageBox.Show("【Debug】选择型号下拉时出现系统错误");
				ex.ToString();
			}
		}
		//归还操作
		void Return_btnClick(object sender, EventArgs e)
		{
			string udep = dep_return.Text.Trim();
			string user = user_return.Text.Trim();
			string name = name_return.Text.Trim();
			string model= model_return.Text.Trim();
			string nums = nums_return.Text.Trim();
			string ctime = return_time.Value.ToString();
			
			if(udep.Length == 0)
				return;
			if(user.Length == 0)
				return;
			if(name.Length == 0)
				return;
			//if(model.Length == 0)
			//	return;
			if(nums.Length == 0)
				return;
			
			string sql = "select rowid from main where name='"+name+"' and model='"+model+"'";
			int rowid = 0;//物品id
			try{
				SQLiteCommand cmd = connection.CreateCommand();
				cmd.CommandText = sql;
				SQLiteDataReader reader = cmd.ExecuteReader();
				if(reader.Read()){
					rowid = int.Parse(reader[0].ToString());
				}
				reader.Close();
				if(rowid>0){
					//计算借出物品数量
					sql = "select sum(nums) from history where main_id="+rowid+" and udep='"+udep+"' and uname='"+user+"' and flag=0";
					int loan_sum = 0;
					cmd.CommandText = sql;
					reader = cmd.ExecuteReader();
					if(reader.Read()){
						string s=reader[0].ToString();
						if(s.Length == 0)
							s="0";
						loan_sum = int.Parse(s);
					}
					reader.Close();
					//计算已经归还物品数量
					sql = "select sum(nums) from history where main_id="+rowid+" and udep='"+udep+"' and uname='"+user+"' and flag=1";
					int return_sum = 0;
					cmd.CommandText = sql;
					reader = cmd.ExecuteReader();
					if(reader.Read()){
						string s=reader[0].ToString();
						if(s.Length == 0)
							s="0";
						return_sum = int.Parse(s);
					}
					reader.Close();
					
					if(loan_sum >= (return_sum + int.Parse(nums))){
						//MessageBox.Show("loan_sum="+loan_sum+",sums="+nums);
						sql = "insert into history (udep,uname,main_id,nums,ctime,flag) values ('"+udep+"','"+user+"',"+rowid.ToString()+","+nums+",'"+ctime+"',1)";
						cmd.CommandText = sql;
						cmd.ExecuteNonQuery();
						sql = "update main set nums=nums+"+nums+" where rowid="+rowid.ToString();
						cmd.CommandText = sql;
						cmd.ExecuteNonQuery();
						MessageBox.Show("归还成功");
					}else{
						MessageBox.Show("您没有领用那么多物品~~归还失败");
					}
				}else{
					MessageBox.Show("未找到相关物品，请核实后重新操作");
				}
				reader.Dispose();
				cmd.Dispose();
			}catch(Exception ex){
				MessageBox.Show("【Debug】归还时出现系统错误");
				ex.ToString();
			}
		}
		//领用界面退出
		void Exit_loan_btnClick(object sender, EventArgs e)
		{
			if(ht_row.Count > 0){
				if(MessageBox.Show("数据尚未保存，是否退出","提示",MessageBoxButtons.YesNo)==DialogResult.No)
					return;
			}
			try{
				connection.Close();
				connection.Dispose();
				connection = null;
			}catch(Exception ex){
				Console.WriteLine(ex.ToString());
			}
			System.Environment.Exit(0);			
		}
		//归还界面退出
		void Exit_return_btnClick(object sender, EventArgs e)
		{
			if(ht_row.Count > 0){
				if(MessageBox.Show("数据尚未保存，是否退出","提示",MessageBoxButtons.YesNo)==DialogResult.No)
					return;
			}
			try{
				connection.Close();
				connection.Dispose();
				connection = null;
			}catch(Exception ex){
				Console.WriteLine(ex.ToString());
			}
			System.Environment.Exit(0);
		}
		//系统界面退出
		void Button1Click(object sender, EventArgs e)
		{
			if(ht_row.Count > 0){
				if(MessageBox.Show("数据尚未保存，是否退出","提示",MessageBoxButtons.YesNo)==DialogResult.No)
					return;
			}
			try{
				connection.Close();
				connection.Dispose();
				connection = null;
			}catch(Exception ex){
				Console.WriteLine(ex.ToString());
			}
			System.Environment.Exit(0);			
		}
		//从领用界面返回主界面
		void Return1_btnClick(object sender, EventArgs e)
		{
			this.tabControl1.SelectedIndex = 0;
		}
		//从归还界面返回主界面
		void Return2_btnClick(object sender, EventArgs e)
		{
			this.tabControl1.SelectedIndex = 0;
		}
		//从系统界面返回主界面
		void Sys_return_btnClick(object sender, EventArgs e)
		{
			this.tabControl1.SelectedIndex = 0;
		}
		//导出数据
		void Exp_btnClick(object sender, EventArgs e)
		{
            string fname = Application.StartupPath + "\\main"+DateTime.Now.ToString("yyyyMMddhhmmss")+".csv";
            using(System.IO.StreamWriter file = new System.IO.StreamWriter(@fname,false,System.Text.Encoding.UTF8))
            {
	        	try{
					SQLiteCommand cmd = connection.CreateCommand();
					SQLiteDataReader reader;
					cmd.CommandText = "select rowid,name,model,nums,source,strftime('%Y-%m-%d %H:%M:%S',ctime),collection,comment from main";
					reader = cmd.ExecuteReader();
					file.WriteLine("序号,物品名称,型号,数量,来源,时间,仓库,备注");
					while(reader.Read()){
						file.WriteLine(reader[0].ToString()+","+reader[1].ToString()+","+reader[2].ToString()+","+reader[3].ToString()+","+reader[4].ToString()+","+reader[5].ToString()+","+reader[6].ToString()+","+reader[7].ToString());
					}
					reader.Close();
					reader.Dispose();
					cmd.Dispose();
				}catch(Exception ex){
            		ex.ToString();
					MessageBox.Show("导出main表出错");
				}
            }
            fname = Application.StartupPath + "\\history"+DateTime.Now.ToString("yyyyMMddhhmmss")+".csv";
            using(System.IO.StreamWriter file = new System.IO.StreamWriter(@fname,false,System.Text.Encoding.UTF8))
            {
	        	try{
					SQLiteCommand cmd = connection.CreateCommand();
					SQLiteDataReader reader;
					cmd.CommandText = "select rowid,udep,uname,main_id,nums,strftime('%Y-%m-%d %H:%M:%S',ctime),flag from history";
					reader = cmd.ExecuteReader();
					string flag = string.Empty;
					file.WriteLine("序号,部门,人员,物品序号,数量,时间,操作");
					while(reader.Read()){
						flag = reader[6].ToString();
						if(flag.Equals("0"))
							flag = "领用";
						else
							flag = "归还";
						file.WriteLine(reader[0].ToString()+","+reader[1].ToString()+","+reader[2].ToString()+","+reader[3].ToString()+","+reader[4].ToString()+","+reader[5].ToString()+","+flag);
					}
					reader.Close();
					reader.Dispose();
					cmd.Dispose();
				}catch(Exception ex){
            		ex.ToString();
					MessageBox.Show("导出history表出错");
				}
            }
            MessageBox.Show("CSV文件保存成功！保存位置：" + Application.StartupPath.ToString());
		}
		//导入数据
		void Imp_btnClick(object sender, EventArgs e)
		{
			string fmain = Application.StartupPath + "\\main.csv";
			string fhistory = Application.StartupPath + "\\history.csv";
			if(File.Exists(fmain)){
				if(MessageBox.Show("导入数据会清空原来 main 表数据，是否继续？","提示",MessageBoxButtons.YesNo)==DialogResult.Yes){
					//导入主表
					using (System.IO.StreamReader sr = new System.IO.StreamReader(@fmain)){
						try{
							string str = sr.ReadLine();//跳过表头
							string sql = "delete from main";
							SQLiteCommand cmd = connection.CreateCommand();
							cmd.CommandText = sql;
							cmd.ExecuteNonQuery();
							while ((str = sr.ReadLine()) != null){
								string[] sArray = Regex.Split(str,",");
								//"序号,物品名称,型号,数量,来源,时间,仓库,备注"
								sql = "insert into main (name,model,nums,source,ctime,collection,comment) values ('"+sArray[1]+"','"+sArray[2]+"',"+sArray[3]+",'"+sArray[4]+"','"+sArray[5]+"','"+sArray[6]+"','"+sArray[7]+"')";
								cmd.CommandText = sql;
								cmd.ExecuteNonQuery();
							}
							cmd.Dispose();
							MessageBox.Show("成功导入main.csv");
						}catch(Exception ex){
							ex.ToString();
							MessageBox.Show("导入main.csv出错");
						}
					}
				}
			}
			if(File.Exists(fhistory)){
				//导入序号表
				if(MessageBox.Show("导入数据会清空原来 history 表数据，是否继续？","提示",MessageBoxButtons.YesNo)==DialogResult.Yes){
					using (System.IO.StreamReader sr = new System.IO.StreamReader(@fhistory)){
						try{
							string str = sr.ReadLine();//跳过表头
							string sql = "delete from history";
							SQLiteCommand cmd = connection.CreateCommand();
							cmd.CommandText = sql;
							cmd.ExecuteNonQuery();
							while ((str = sr.ReadLine()) != null){
								if(str.Trim().Length == 0)
									continue;
								string[] sArray = Regex.Split(str,",");
								//"序号,部门,人员,物品序号,数量,时间,操作"
								if(sArray[6].Equals("领用"))
									sArray[6] = "0";
								else
									sArray[6] = "1";
								sql = "insert into history (udep,uname,main_id,nums,ctime,flag) values ('"+sArray[1]+"','"+sArray[2]+"',"+sArray[3]+","+sArray[4]+",'"+sArray[5]+"',"+sArray[6]+")";
								cmd.CommandText = sql;
								cmd.ExecuteNonQuery();
							}
							cmd.Dispose();
							MessageBox.Show("成功导入history.csv");
						}catch(Exception ex){
							ex.ToString();
							MessageBox.Show("导入history.csv出错");
						}
					}
				}
			}
			load_main_table();
		}
//		//转换时间格式
//		string time_conv(string str){
//			//2016/9/11 13:05
//			string[] s = Regex.Split(str," ");
//			string[] cdate = new String[3];
//			
//			if(s[0].Substring(4,1).Equals("/"))
//				cdate = Regex.Split(s[0],"/");
//			else
//				cdate = Regex.Split(s[0],"-");
//			
//			if(cdate[1].Length == 1)
//				cdate[1] = "0"+cdate[1];
//			if(cdate[2].Length == 1)
//				cdate[2] = "0"+cdate[2];
//			
//			return cdate[0] + "-" + cdate[1] + "-" + cdate[2] + " " + s[1];
//		}
		
		void Refresh_btnClick(object sender, EventArgs e)
		{
			load_main_table();
		}
	}
}
