/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2016/5/29
 * Time: 21:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace test
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.label25 = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.refresh_btn = new System.Windows.Forms.Button();
			this.exp_btn = new System.Windows.Forms.Button();
			this.imp_btn = new System.Windows.Forms.Button();
			this.search_key = new System.Windows.Forms.ComboBox();
			this.search_txt = new System.Windows.Forms.TextBox();
			this.search_btn = new System.Windows.Forms.Button();
			this.dgv0 = new System.Windows.Forms.DataGridView();
			this.save_btn = new System.Windows.Forms.Button();
			this.exit_btn = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.search_key2 = new System.Windows.Forms.ComboBox();
			this.search_txt2 = new System.Windows.Forms.TextBox();
			this.search_btn2 = new System.Windows.Forms.Button();
			this.dgv2 = new System.Windows.Forms.DataGridView();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.loan_time = new System.Windows.Forms.DateTimePicker();
			this.label15 = new System.Windows.Forms.Label();
			this.model_loan = new System.Windows.Forms.ComboBox();
			this.user_loan = new System.Windows.Forms.ComboBox();
			this.dep_loan = new System.Windows.Forms.ComboBox();
			this.name_loan = new System.Windows.Forms.ComboBox();
			this.nums_loan = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.exit_loan_btn = new System.Windows.Forms.Button();
			this.loan_btn = new System.Windows.Forms.Button();
			this.return1_btn = new System.Windows.Forms.Button();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.return_time = new System.Windows.Forms.DateTimePicker();
			this.label16 = new System.Windows.Forms.Label();
			this.model_return = new System.Windows.Forms.ComboBox();
			this.user_return = new System.Windows.Forms.ComboBox();
			this.dep_return = new System.Windows.Forms.ComboBox();
			this.name_return = new System.Windows.Forms.ComboBox();
			this.nums_return = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.exit_return_btn = new System.Windows.Forms.Button();
			this.return_btn = new System.Windows.Forms.Button();
			this.return2_btn = new System.Windows.Forms.Button();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.sys_return_btn = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txt3_yonghumingcheng = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt3_querenmima = new System.Windows.Forms.TextBox();
			this.txt3_xinmima = new System.Windows.Forms.TextBox();
			this.txt3_yuanmima = new System.Windows.Forms.TextBox();
			this.change_pass_btn = new System.Windows.Forms.Button();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.loan_return_menu = new System.Windows.Forms.ToolStripMenuItem();
			this.record_delete_menu = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv0)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(154, 146);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(313, 40);
			this.label25.TabIndex = 0;
			this.label25.Text = "统计结果在这里显示";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer1.Size = new System.Drawing.Size(1294, 703);
			this.splitContainer1.SplitterDistance = 80;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1294, 80);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1294, 618);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.refresh_btn);
			this.tabPage1.Controls.Add(this.exp_btn);
			this.tabPage1.Controls.Add(this.imp_btn);
			this.tabPage1.Controls.Add(this.search_key);
			this.tabPage1.Controls.Add(this.search_txt);
			this.tabPage1.Controls.Add(this.search_btn);
			this.tabPage1.Controls.Add(this.dgv0);
			this.tabPage1.Controls.Add(this.save_btn);
			this.tabPage1.Controls.Add(this.exit_btn);
			this.tabPage1.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tabPage1.Size = new System.Drawing.Size(1286, 585);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "库存现状";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// refresh_btn
			// 
			this.refresh_btn.Location = new System.Drawing.Point(11, 545);
			this.refresh_btn.Name = "refresh_btn";
			this.refresh_btn.Size = new System.Drawing.Size(90, 33);
			this.refresh_btn.TabIndex = 85;
			this.refresh_btn.Text = "刷新";
			this.refresh_btn.UseVisualStyleBackColor = true;
			this.refresh_btn.Click += new System.EventHandler(this.Refresh_btnClick);
			// 
			// exp_btn
			// 
			this.exp_btn.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.exp_btn.Location = new System.Drawing.Point(771, 547);
			this.exp_btn.Name = "exp_btn";
			this.exp_btn.Size = new System.Drawing.Size(79, 32);
			this.exp_btn.TabIndex = 84;
			this.exp_btn.Text = "导出";
			this.exp_btn.UseVisualStyleBackColor = true;
			this.exp_btn.Click += new System.EventHandler(this.Exp_btnClick);
			// 
			// imp_btn
			// 
			this.imp_btn.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.imp_btn.Location = new System.Drawing.Point(895, 547);
			this.imp_btn.Name = "imp_btn";
			this.imp_btn.Size = new System.Drawing.Size(79, 32);
			this.imp_btn.TabIndex = 83;
			this.imp_btn.Text = "导入";
			this.imp_btn.UseVisualStyleBackColor = true;
			this.imp_btn.Click += new System.EventHandler(this.Imp_btnClick);
			// 
			// search_key
			// 
			this.search_key.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.search_key.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.search_key.FormattingEnabled = true;
			this.search_key.Items.AddRange(new object[] {
									"物品名称",
									"型号",
									"部门",
									"领取人"});
			this.search_key.Location = new System.Drawing.Point(272, 546);
			this.search_key.Name = "search_key";
			this.search_key.Size = new System.Drawing.Size(121, 32);
			this.search_key.TabIndex = 40;
			// 
			// search_txt
			// 
			this.search_txt.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.search_txt.Location = new System.Drawing.Point(395, 546);
			this.search_txt.Name = "search_txt";
			this.search_txt.Size = new System.Drawing.Size(191, 31);
			this.search_txt.TabIndex = 39;
			// 
			// search_btn
			// 
			this.search_btn.Location = new System.Drawing.Point(588, 544);
			this.search_btn.Name = "search_btn";
			this.search_btn.Size = new System.Drawing.Size(90, 33);
			this.search_btn.TabIndex = 38;
			this.search_btn.Text = "搜索";
			this.search_btn.UseVisualStyleBackColor = true;
			this.search_btn.Click += new System.EventHandler(this.Search_btnClick);
			// 
			// dgv0
			// 
			this.dgv0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv0.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgv0.Location = new System.Drawing.Point(4, 3);
			this.dgv0.MultiSelect = false;
			this.dgv0.Name = "dgv0";
			this.dgv0.RowTemplate.Height = 23;
			this.dgv0.Size = new System.Drawing.Size(1278, 524);
			this.dgv0.TabIndex = 36;
			this.dgv0.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv0CellMouseDown);
			this.dgv0.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv0CellValueChanged);
			// 
			// save_btn
			// 
			this.save_btn.Location = new System.Drawing.Point(148, 544);
			this.save_btn.Name = "save_btn";
			this.save_btn.Size = new System.Drawing.Size(90, 33);
			this.save_btn.TabIndex = 35;
			this.save_btn.Text = "存盘";
			this.save_btn.UseVisualStyleBackColor = true;
			this.save_btn.Click += new System.EventHandler(this.Save_btnClick);
			// 
			// exit_btn
			// 
			this.exit_btn.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.exit_btn.Location = new System.Drawing.Point(1003, 544);
			this.exit_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.exit_btn.Name = "exit_btn";
			this.exit_btn.Size = new System.Drawing.Size(90, 33);
			this.exit_btn.TabIndex = 33;
			this.exit_btn.Text = "退出";
			this.exit_btn.UseVisualStyleBackColor = true;
			this.exit_btn.Click += new System.EventHandler(this.Exit_btnClick);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.search_key2);
			this.tabPage2.Controls.Add(this.search_txt2);
			this.tabPage2.Controls.Add(this.search_btn2);
			this.tabPage2.Controls.Add(this.dgv2);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(1286, 585);
			this.tabPage2.TabIndex = 6;
			this.tabPage2.Text = "检索";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// search_key2
			// 
			this.search_key2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.search_key2.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.search_key2.FormattingEnabled = true;
			this.search_key2.Items.AddRange(new object[] {
									"全部",
									"部门",
									"领取人"});
			this.search_key2.Location = new System.Drawing.Point(441, 528);
			this.search_key2.Name = "search_key2";
			this.search_key2.Size = new System.Drawing.Size(121, 32);
			this.search_key2.TabIndex = 43;
			// 
			// search_txt2
			// 
			this.search_txt2.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.search_txt2.Location = new System.Drawing.Point(564, 528);
			this.search_txt2.Name = "search_txt2";
			this.search_txt2.Size = new System.Drawing.Size(191, 31);
			this.search_txt2.TabIndex = 42;
			// 
			// search_btn2
			// 
			this.search_btn2.Location = new System.Drawing.Point(757, 526);
			this.search_btn2.Name = "search_btn2";
			this.search_btn2.Size = new System.Drawing.Size(90, 33);
			this.search_btn2.TabIndex = 41;
			this.search_btn2.Text = "搜索";
			this.search_btn2.UseVisualStyleBackColor = true;
			this.search_btn2.Click += new System.EventHandler(this.Search_btn2Click);
			// 
			// dgv2
			// 
			this.dgv2.AllowUserToAddRows = false;
			this.dgv2.AllowUserToDeleteRows = false;
			this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv2.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgv2.Location = new System.Drawing.Point(0, 0);
			this.dgv2.Name = "dgv2";
			this.dgv2.ReadOnly = true;
			this.dgv2.RowTemplate.Height = 23;
			this.dgv2.Size = new System.Drawing.Size(1286, 499);
			this.dgv2.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.loan_time);
			this.tabPage3.Controls.Add(this.label15);
			this.tabPage3.Controls.Add(this.model_loan);
			this.tabPage3.Controls.Add(this.user_loan);
			this.tabPage3.Controls.Add(this.dep_loan);
			this.tabPage3.Controls.Add(this.name_loan);
			this.tabPage3.Controls.Add(this.nums_loan);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Controls.Add(this.label5);
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Controls.Add(this.label3);
			this.tabPage3.Controls.Add(this.label1);
			this.tabPage3.Controls.Add(this.exit_loan_btn);
			this.tabPage3.Controls.Add(this.loan_btn);
			this.tabPage3.Controls.Add(this.return1_btn);
			this.tabPage3.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tabPage3.Location = new System.Drawing.Point(4, 29);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tabPage3.Size = new System.Drawing.Size(1286, 585);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "领用";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// loan_time
			// 
			this.loan_time.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.loan_time.Location = new System.Drawing.Point(532, 428);
			this.loan_time.Name = "loan_time";
			this.loan_time.Size = new System.Drawing.Size(279, 28);
			this.loan_time.TabIndex = 55;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label15.Location = new System.Drawing.Point(411, 426);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(74, 35);
			this.label15.TabIndex = 54;
			this.label15.Text = "时间";
			// 
			// model_loan
			// 
			this.model_loan.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.model_loan.FormattingEnabled = true;
			this.model_loan.Location = new System.Drawing.Point(532, 310);
			this.model_loan.Name = "model_loan";
			this.model_loan.Size = new System.Drawing.Size(278, 32);
			this.model_loan.TabIndex = 53;
			this.model_loan.DropDown += new System.EventHandler(this.Model_loanDropDown);
			// 
			// user_loan
			// 
			this.user_loan.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.user_loan.FormattingEnabled = true;
			this.user_loan.Location = new System.Drawing.Point(532, 193);
			this.user_loan.Name = "user_loan";
			this.user_loan.Size = new System.Drawing.Size(278, 32);
			this.user_loan.TabIndex = 52;
			this.user_loan.DropDown += new System.EventHandler(this.User_loanDropDown);
			// 
			// dep_loan
			// 
			this.dep_loan.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.dep_loan.FormattingEnabled = true;
			this.dep_loan.Location = new System.Drawing.Point(532, 132);
			this.dep_loan.Name = "dep_loan";
			this.dep_loan.Size = new System.Drawing.Size(278, 32);
			this.dep_loan.TabIndex = 51;
			this.dep_loan.DropDown += new System.EventHandler(this.Dep_loanDropDown);
			// 
			// name_loan
			// 
			this.name_loan.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.name_loan.FormattingEnabled = true;
			this.name_loan.Location = new System.Drawing.Point(532, 253);
			this.name_loan.Name = "name_loan";
			this.name_loan.Size = new System.Drawing.Size(278, 32);
			this.name_loan.TabIndex = 50;
			this.name_loan.DropDown += new System.EventHandler(this.Name_loanDropDown);
			// 
			// nums_loan
			// 
			this.nums_loan.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.nums_loan.Location = new System.Drawing.Point(532, 358);
			this.nums_loan.Name = "nums_loan";
			this.nums_loan.Size = new System.Drawing.Size(279, 34);
			this.nums_loan.TabIndex = 49;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label7.Location = new System.Drawing.Point(411, 361);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 35);
			this.label7.TabIndex = 44;
			this.label7.Text = "数量";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label6.Location = new System.Drawing.Point(411, 305);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 35);
			this.label6.TabIndex = 43;
			this.label6.Text = "型号";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(351, 251);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(134, 35);
			this.label5.TabIndex = 42;
			this.label5.Text = "物品名称";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(411, 193);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 35);
			this.label4.TabIndex = 41;
			this.label4.Text = "人员";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(411, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 35);
			this.label3.TabIndex = 40;
			this.label3.Text = "部门";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(490, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(254, 38);
			this.label1.TabIndex = 39;
			this.label1.Text = "物资领用管理模块";
			// 
			// exit_loan_btn
			// 
			this.exit_loan_btn.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.exit_loan_btn.Location = new System.Drawing.Point(754, 494);
			this.exit_loan_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.exit_loan_btn.Name = "exit_loan_btn";
			this.exit_loan_btn.Size = new System.Drawing.Size(118, 39);
			this.exit_loan_btn.TabIndex = 38;
			this.exit_loan_btn.Text = "退出";
			this.exit_loan_btn.UseVisualStyleBackColor = true;
			this.exit_loan_btn.Click += new System.EventHandler(this.Exit_loan_btnClick);
			// 
			// loan_btn
			// 
			this.loan_btn.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.loan_btn.Location = new System.Drawing.Point(375, 494);
			this.loan_btn.Name = "loan_btn";
			this.loan_btn.Size = new System.Drawing.Size(127, 39);
			this.loan_btn.TabIndex = 37;
			this.loan_btn.Text = "领用";
			this.loan_btn.UseVisualStyleBackColor = true;
			this.loan_btn.Click += new System.EventHandler(this.Loan_btnClick);
			// 
			// return1_btn
			// 
			this.return1_btn.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.return1_btn.Location = new System.Drawing.Point(563, 494);
			this.return1_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.return1_btn.Name = "return1_btn";
			this.return1_btn.Size = new System.Drawing.Size(118, 39);
			this.return1_btn.TabIndex = 36;
			this.return1_btn.Text = "返回";
			this.return1_btn.UseVisualStyleBackColor = true;
			this.return1_btn.Click += new System.EventHandler(this.Return1_btnClick);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.return_time);
			this.tabPage4.Controls.Add(this.label16);
			this.tabPage4.Controls.Add(this.model_return);
			this.tabPage4.Controls.Add(this.user_return);
			this.tabPage4.Controls.Add(this.dep_return);
			this.tabPage4.Controls.Add(this.name_return);
			this.tabPage4.Controls.Add(this.nums_return);
			this.tabPage4.Controls.Add(this.label8);
			this.tabPage4.Controls.Add(this.label9);
			this.tabPage4.Controls.Add(this.label10);
			this.tabPage4.Controls.Add(this.label11);
			this.tabPage4.Controls.Add(this.label12);
			this.tabPage4.Controls.Add(this.label13);
			this.tabPage4.Controls.Add(this.exit_return_btn);
			this.tabPage4.Controls.Add(this.return_btn);
			this.tabPage4.Controls.Add(this.return2_btn);
			this.tabPage4.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tabPage4.Location = new System.Drawing.Point(4, 29);
			this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tabPage4.Size = new System.Drawing.Size(1286, 585);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "归还";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// return_time
			// 
			this.return_time.Location = new System.Drawing.Point(538, 429);
			this.return_time.Name = "return_time";
			this.return_time.Size = new System.Drawing.Size(279, 28);
			this.return_time.TabIndex = 65;
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label16.Location = new System.Drawing.Point(417, 427);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(74, 35);
			this.label16.TabIndex = 64;
			this.label16.Text = "时间";
			// 
			// model_return
			// 
			this.model_return.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.model_return.FormattingEnabled = true;
			this.model_return.Location = new System.Drawing.Point(538, 303);
			this.model_return.Name = "model_return";
			this.model_return.Size = new System.Drawing.Size(278, 32);
			this.model_return.TabIndex = 63;
			this.model_return.DropDown += new System.EventHandler(this.Model_returnDropDown);
			// 
			// user_return
			// 
			this.user_return.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.user_return.FormattingEnabled = true;
			this.user_return.Location = new System.Drawing.Point(538, 186);
			this.user_return.Name = "user_return";
			this.user_return.Size = new System.Drawing.Size(278, 32);
			this.user_return.TabIndex = 62;
			this.user_return.DropDown += new System.EventHandler(this.User_returnDropDown);
			// 
			// dep_return
			// 
			this.dep_return.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.dep_return.FormattingEnabled = true;
			this.dep_return.Location = new System.Drawing.Point(538, 125);
			this.dep_return.Name = "dep_return";
			this.dep_return.Size = new System.Drawing.Size(278, 32);
			this.dep_return.TabIndex = 61;
			this.dep_return.DropDown += new System.EventHandler(this.Dep_returnDropDown);
			// 
			// name_return
			// 
			this.name_return.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.name_return.FormattingEnabled = true;
			this.name_return.Location = new System.Drawing.Point(538, 246);
			this.name_return.Name = "name_return";
			this.name_return.Size = new System.Drawing.Size(278, 32);
			this.name_return.TabIndex = 60;
			this.name_return.DropDown += new System.EventHandler(this.Name_returnDropDown);
			// 
			// nums_return
			// 
			this.nums_return.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.nums_return.Location = new System.Drawing.Point(538, 351);
			this.nums_return.Name = "nums_return";
			this.nums_return.Size = new System.Drawing.Size(279, 34);
			this.nums_return.TabIndex = 59;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(417, 354);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 35);
			this.label8.TabIndex = 58;
			this.label8.Text = "数量";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label9.Location = new System.Drawing.Point(417, 298);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(74, 35);
			this.label9.TabIndex = 57;
			this.label9.Text = "型号";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label10.Location = new System.Drawing.Point(357, 244);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(134, 35);
			this.label10.TabIndex = 56;
			this.label10.Text = "物品名称";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label11.Location = new System.Drawing.Point(417, 186);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(74, 35);
			this.label11.TabIndex = 55;
			this.label11.Text = "人员";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label12.Location = new System.Drawing.Point(417, 125);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(74, 35);
			this.label12.TabIndex = 54;
			this.label12.Text = "部门";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label13.Location = new System.Drawing.Point(459, 39);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(254, 38);
			this.label13.TabIndex = 50;
			this.label13.Text = "物资归还管理模块";
			// 
			// exit_return_btn
			// 
			this.exit_return_btn.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.exit_return_btn.Location = new System.Drawing.Point(786, 492);
			this.exit_return_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.exit_return_btn.Name = "exit_return_btn";
			this.exit_return_btn.Size = new System.Drawing.Size(118, 39);
			this.exit_return_btn.TabIndex = 38;
			this.exit_return_btn.Text = "退出";
			this.exit_return_btn.UseVisualStyleBackColor = true;
			this.exit_return_btn.Click += new System.EventHandler(this.Exit_return_btnClick);
			// 
			// return_btn
			// 
			this.return_btn.Location = new System.Drawing.Point(354, 492);
			this.return_btn.Name = "return_btn";
			this.return_btn.Size = new System.Drawing.Size(127, 39);
			this.return_btn.TabIndex = 37;
			this.return_btn.Text = "归还";
			this.return_btn.UseVisualStyleBackColor = true;
			this.return_btn.Click += new System.EventHandler(this.Return_btnClick);
			// 
			// return2_btn
			// 
			this.return2_btn.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.return2_btn.Location = new System.Drawing.Point(581, 492);
			this.return2_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.return2_btn.Name = "return2_btn";
			this.return2_btn.Size = new System.Drawing.Size(118, 39);
			this.return2_btn.TabIndex = 36;
			this.return2_btn.Text = "返回";
			this.return2_btn.UseVisualStyleBackColor = true;
			this.return2_btn.Click += new System.EventHandler(this.Return2_btnClick);
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.sys_return_btn);
			this.tabPage5.Controls.Add(this.button1);
			this.tabPage5.Controls.Add(this.groupBox3);
			this.tabPage5.Location = new System.Drawing.Point(4, 29);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(1286, 585);
			this.tabPage5.TabIndex = 5;
			this.tabPage5.Text = "系统";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// sys_return_btn
			// 
			this.sys_return_btn.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.sys_return_btn.Location = new System.Drawing.Point(415, 463);
			this.sys_return_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.sys_return_btn.Name = "sys_return_btn";
			this.sys_return_btn.Size = new System.Drawing.Size(123, 39);
			this.sys_return_btn.TabIndex = 78;
			this.sys_return_btn.Text = "返  回";
			this.sys_return_btn.UseVisualStyleBackColor = true;
			this.sys_return_btn.Click += new System.EventHandler(this.Sys_return_btnClick);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.Location = new System.Drawing.Point(716, 463);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(123, 39);
			this.button1.TabIndex = 77;
			this.button1.Text = "退出程序";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txt3_yonghumingcheng);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.txt3_querenmima);
			this.groupBox3.Controls.Add(this.txt3_xinmima);
			this.groupBox3.Controls.Add(this.txt3_yuanmima);
			this.groupBox3.Controls.Add(this.change_pass_btn);
			this.groupBox3.Controls.Add(this.label19);
			this.groupBox3.Controls.Add(this.label18);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Location = new System.Drawing.Point(415, 65);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(424, 353);
			this.groupBox3.TabIndex = 75;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "修改密码";
			// 
			// txt3_yonghumingcheng
			// 
			this.txt3_yonghumingcheng.Font = new System.Drawing.Font("幼圆", 21.75F);
			this.txt3_yonghumingcheng.Location = new System.Drawing.Point(196, 30);
			this.txt3_yonghumingcheng.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txt3_yonghumingcheng.Name = "txt3_yonghumingcheng";
			this.txt3_yonghumingcheng.Size = new System.Drawing.Size(183, 39);
			this.txt3_yonghumingcheng.TabIndex = 70;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(34, 33);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 48);
			this.label2.TabIndex = 69;
			this.label2.Text = "用户名称";
			// 
			// txt3_querenmima
			// 
			this.txt3_querenmima.Font = new System.Drawing.Font("幼圆", 21.75F);
			this.txt3_querenmima.Location = new System.Drawing.Point(196, 220);
			this.txt3_querenmima.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txt3_querenmima.Name = "txt3_querenmima";
			this.txt3_querenmima.PasswordChar = '*';
			this.txt3_querenmima.Size = new System.Drawing.Size(183, 39);
			this.txt3_querenmima.TabIndex = 68;
			// 
			// txt3_xinmima
			// 
			this.txt3_xinmima.Font = new System.Drawing.Font("幼圆", 21.75F);
			this.txt3_xinmima.Location = new System.Drawing.Point(196, 158);
			this.txt3_xinmima.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txt3_xinmima.Name = "txt3_xinmima";
			this.txt3_xinmima.PasswordChar = '*';
			this.txt3_xinmima.Size = new System.Drawing.Size(183, 39);
			this.txt3_xinmima.TabIndex = 67;
			// 
			// txt3_yuanmima
			// 
			this.txt3_yuanmima.Font = new System.Drawing.Font("幼圆", 21.75F);
			this.txt3_yuanmima.Location = new System.Drawing.Point(196, 91);
			this.txt3_yuanmima.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txt3_yuanmima.Name = "txt3_yuanmima";
			this.txt3_yuanmima.PasswordChar = '*';
			this.txt3_yuanmima.Size = new System.Drawing.Size(183, 39);
			this.txt3_yuanmima.TabIndex = 66;
			// 
			// change_pass_btn
			// 
			this.change_pass_btn.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.change_pass_btn.Location = new System.Drawing.Point(159, 288);
			this.change_pass_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.change_pass_btn.Name = "change_pass_btn";
			this.change_pass_btn.Size = new System.Drawing.Size(119, 35);
			this.change_pass_btn.TabIndex = 65;
			this.change_pass_btn.Text = "确定修改";
			this.change_pass_btn.UseVisualStyleBackColor = true;
			this.change_pass_btn.Click += new System.EventHandler(this.Change_pass_btnClick);
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label19.Location = new System.Drawing.Point(34, 220);
			this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(148, 48);
			this.label19.TabIndex = 64;
			this.label19.Text = "确认密码";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label18.Location = new System.Drawing.Point(65, 155);
			this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(117, 48);
			this.label18.TabIndex = 63;
			this.label18.Text = "新密码";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label14.Location = new System.Drawing.Point(65, 94);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(117, 48);
			this.label14.TabIndex = 62;
			this.label14.Text = "原密码";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.loan_return_menu,
									this.record_delete_menu});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(149, 48);
			// 
			// loan_return_menu
			// 
			this.loan_return_menu.Name = "loan_return_menu";
			this.loan_return_menu.Size = new System.Drawing.Size(148, 22);
			this.loan_return_menu.Text = "查看借还";
			this.loan_return_menu.Click += new System.EventHandler(this.Loan_return_menuClick);
			// 
			// record_delete_menu
			// 
			this.record_delete_menu.Name = "record_delete_menu";
			this.record_delete_menu.Size = new System.Drawing.Size(148, 22);
			this.record_delete_menu.Text = "删除本条记录";
			this.record_delete_menu.Click += new System.EventHandler(this.Record_delete_menuClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1294, 703);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "进销存管理系统";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv0)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.tabPage5.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button search_btn2;
		private System.Windows.Forms.TextBox search_txt2;
		private System.Windows.Forms.ComboBox search_key2;
		private System.Windows.Forms.DataGridView dgv2;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button refresh_btn;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.DateTimePicker return_time;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.DateTimePicker loan_time;
		private System.Windows.Forms.Button exp_btn;
		private System.Windows.Forms.Button imp_btn;
		private System.Windows.Forms.ComboBox search_key;
		private System.Windows.Forms.Button search_btn;
		private System.Windows.Forms.TextBox search_txt;
		private System.Windows.Forms.TextBox nums_return;
		private System.Windows.Forms.ComboBox name_return;
		private System.Windows.Forms.ComboBox dep_return;
		private System.Windows.Forms.ComboBox user_return;
		private System.Windows.Forms.ComboBox model_return;
		private System.Windows.Forms.ComboBox name_loan;
		private System.Windows.Forms.ComboBox dep_loan;
		private System.Windows.Forms.ComboBox user_loan;
		private System.Windows.Forms.ComboBox model_loan;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox nums_loan;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button return2_btn;
		private System.Windows.Forms.Button return_btn;
		private System.Windows.Forms.Button exit_return_btn;
		private System.Windows.Forms.Button return1_btn;
		private System.Windows.Forms.Button loan_btn;
		private System.Windows.Forms.Button exit_loan_btn;
		private System.Windows.Forms.Button sys_return_btn;
		private System.Windows.Forms.ToolStripMenuItem record_delete_menu;
		private System.Windows.Forms.ToolStripMenuItem loan_return_menu;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button save_btn;
		private System.Windows.Forms.DataGridView dgv0;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button exit_btn;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt3_yonghumingcheng;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Button change_pass_btn;
		private System.Windows.Forms.TextBox txt3_yuanmima;
		private System.Windows.Forms.TextBox txt3_xinmima;
		private System.Windows.Forms.TextBox txt3_querenmima;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label25;
		//private System.Windows.Forms.SplitContainer splitContainer1;
	}
}
