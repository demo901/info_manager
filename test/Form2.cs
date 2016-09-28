/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2016/9/11
 * Time: 15:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections;

namespace test
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		private SQLiteConnection connection = null;
		private Hashtable ht_row = new Hashtable();//被修改的记录id
		private int sid = 0;
		public Form2(int id)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			string dbname = System.Configuration.ConfigurationSettings.AppSettings["db_file"];
			connection = new SQLiteConnection(@"Data Source=" + dbname + ";Pooling=true;FailIfMissing=false");
			connection.Open();

			dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;//列宽不自动调整,手工添加列
			dgv1.AlternatingRowsDefaultCellStyle.BackColor = Color.LemonChiffon;//奇数行背景色
			dgv1.BackgroundColor = Color.White;//控件背景色
			dgv1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//列标题居中显示
			dgv1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//单元格内容居中显示
			dgv1.AutoGenerateColumns = false;//不自动创建列
			
			sid = id;
			load_main_table();
		}
		private void load_main_table(){
			dgv1.Rows.Clear();
			dgv1.Columns.Clear();
			ht_row.Clear();
			
			dgv1.Columns.Add("sid","流水号");
			dgv1.Columns.Add("udep","部门");
			dgv1.Columns.Add("uname","人员");
			dgv1.Columns.Add("nums","数量");
			dgv1.Columns.Add("ctime","时间");
			dgv1.Columns.Add("flag","借/还");
			dgv1.Columns[0].ReadOnly = true;
			dgv1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			
			
			SQLiteCommand cmd = connection.CreateCommand();
			SQLiteDataReader reader;
			cmd.CommandText = "select rowid,udep,uname,nums,ctime,flag from history where main_id="+sid;
			reader = cmd.ExecuteReader();
			while(reader.Read()){
				string flag = reader[5].ToString();
				if(flag.Equals("0"))
					flag = "领用";
				else
					flag = "归还";
				dgv1.Rows.Add(new object[] {
	              	reader[0].ToString(),
	              	reader[1].ToString(),
	              	reader[2].ToString(),
	              	reader[3].ToString(),
	              	reader[4].ToString(),
	              	flag,
				});
			}
			reader.Close();
			reader.Dispose();
			cmd.Dispose();
		}
		//弹出右键菜单
		void Dgv1CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
			    if (e.RowIndex >= 0)
			    {
			        //若行已是选中状态就不再进行设置
			        if (dgv1.Rows[e.RowIndex].Selected == false)
			        {
			            dgv1.ClearSelection();
			            dgv1.Rows[e.RowIndex].Selected = true;
			        }
			        //只选中一行时设置活动单元格
			        if (dgv1.SelectedRows.Count == 1)
			        {
			            dgv1.CurrentCell = dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex];
			        }
			        //弹出操作菜单
			        contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
			    }
			}
		}
		//单元格内容改变时
		void Dgv1CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			int rowid = e.RowIndex;
			string id = string.Empty;
			try{
				id = this.dgv1.Rows[rowid].Cells[0].Value.ToString();
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
		//删除记录操作 -- 鼠标右键
		void Record_delete_menuClick(object sender, EventArgs e)
		{
			string rowid = this.dgv1.CurrentRow.Cells[0].RowIndex.ToString();
			string id = string.Empty;
			try{
				id = this.dgv1.CurrentRow.Cells[0].Value.ToString();
				if(!ht_row.Contains("D"+rowid)){
					ht_row.Add("D"+rowid,id);
					//MessageBox.Show("D"+rowid);
				}
			}catch(NullReferenceException e0){
				Console.WriteLine(e0.ToString());
				id = this.dgv1.CurrentRow.Cells[0].RowIndex.ToString();
				if(!ht_row.Contains("N"+rowid))
					ht_row.Add("N"+rowid,id);
			}
		}
		//放弃修改或已存盘
		void Abort_btnClick(object sender, EventArgs e)
		{
			if(ht_row.Count > 0){
				if(MessageBox.Show("数据尚未保存,是否确定退出","提示",MessageBoxButtons.YesNo)==DialogResult.No){
					return;
				}
			}
			try{
				connection.Close();
				connection.Dispose();
				connection = null;
			}catch(Exception ex){
				Console.WriteLine(ex.ToString());
			}
			this.Close();
			this.Dispose();
		}
		//刷新数据
		void Refresh_btnClick(object sender, EventArgs e)
		{
			if(ht_row.Count > 0){
				if(MessageBox.Show("数据尚未保存，是否刷新","提示",MessageBoxButtons.YesNo)==DialogResult.No)
					return;
			}
			this.load_main_table();
		}
		//存盘
		void Save_btnClick(object sender, EventArgs e)
		{
			if(ht_row.Count == 0)
				return;
			SQLiteCommand cmd = connection.CreateCommand();
			string flag = string.Empty;
			int rowid = 0;//数据库的rowid
			int rowindex = 0;//表格的行号
			string sql = string.Empty;
			string udep = string.Empty;
			string uname = string.Empty;
			string nums = string.Empty;
			string ctime = string.Empty;
			string loan = string.Empty;
			try{
				foreach (DictionaryEntry de in ht_row)
				{
					flag = de.Key.ToString().Substring(0,1);
					rowindex = int.Parse(de.Key.ToString().Substring(1));
					rowid = int.Parse(de.Value.ToString());

					if(dgv1.Rows[rowindex].Cells[1].Value != null)
						udep = dgv1.Rows[rowindex].Cells[1].Value.ToString();
					else
						udep = "";
					if(dgv1.Rows[rowindex].Cells[2].Value != null)
						uname= dgv1.Rows[rowindex].Cells[2].Value.ToString();
					else
						uname = "";
					if(dgv1.Rows[rowindex].Cells[3].Value != null)
						nums = dgv1.Rows[rowindex].Cells[3].Value.ToString();
					else
						nums = "0";
					if(dgv1.Rows[rowindex].Cells[4].Value != null)
						ctime = dgv1.Rows[rowindex].Cells[4].Value.ToString();
					else
						ctime = "";
					if(dgv1.Rows[rowindex].Cells[5].Value != null)
						loan = dgv1.Rows[rowindex].Cells[5].Value.ToString();
					else
						loan = "";
					if(loan.Trim().Equals("领用"))
						loan = "0";
					else
						loan = "1";
					if(flag.Equals("A")){//新增记录
						sql = "insert into history (main_id,udep,uname,nums,ctime,flag) values ("+sid+",'"+udep+"','"+uname+"',"+nums+",'"+ctime+"',"+loan+")";
						cmd.CommandText = sql;
						cmd.ExecuteNonQuery();
						if(loan.Equals("0"))
							sql = "update main set nums=nums-"+nums+" where rowid="+sid;
						else
							sql = "update main set nums=nums+"+nums+" where rowid="+sid;
						cmd.CommandText = sql;
						cmd.ExecuteNonQuery();
						continue;
					}
					if(flag.Equals("D")){
						sql = "delete from history where rowid="+rowid;
						cmd.CommandText = sql;
						cmd.ExecuteNonQuery();
						if(loan.Equals("0"))
							sql = "update main set nums=nums+"+nums+" where rowid="+sid;
						else
							sql = "update main set nums=nums-"+nums+" where rowid="+sid;
						cmd.CommandText = sql;
						cmd.ExecuteNonQuery();
					}
					int save_nums = 0;//保存修改前的字段值
					int main_id = 0;
					string save_flag = "";
					if(flag.Equals("E")){//修改记录
						sql = "select main_id,nums,flag from history where rowid="+rowid;
						cmd.CommandText = sql;
						SQLiteDataReader reader = cmd.ExecuteReader();
						while(reader.Read()){
							main_id = int.Parse(reader[0].ToString());
							save_nums = int.Parse(reader[1].ToString());
							save_flag = reader[2].ToString();
						}
						reader.Close();
						reader.Dispose();
						
						sql = "update history set udep='"+udep+"',uname='"+uname+"',nums="+nums+",flag="+loan+" where rowid="+rowid;
						cmd.CommandText = sql;
						cmd.ExecuteNonQuery();
						if(!save_flag.Equals(loan)){
							if(loan.Equals("0"))
								sql = "update main set nums=nums-"+(save_nums+int.Parse(nums))+" where rowid="+main_id;
							else
								sql = "update main set nums=nums+"+(int.Parse(nums)+save_nums)+" where rowid="+main_id;
							cmd.CommandText = sql;
							cmd.ExecuteNonQuery();
						}
					}
					//数量或操作有变化需要同步main主表
					if((save_nums != int.Parse(nums)) && (save_flag.Equals(loan))){
						if(loan.Equals("0"))
							sql = "update main set nums=nums-"+(int.Parse(nums)-save_nums)+" where rowid="+main_id;
						else
							sql = "update main set nums=nums+"+(int.Parse(nums)-save_nums)+" where rowid="+main_id;
						cmd.CommandText = sql;
						cmd.ExecuteNonQuery();
					}
				}
			}catch(Exception ex){
				Console.WriteLine(ex.ToString());
				MessageBox.Show("保存数据时出现错误");
			}
			ht_row.Clear();
			load_main_table();
		}
	}
}
