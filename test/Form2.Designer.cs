/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2016/9/11
 * Time: 15:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace test
{
	partial class Form2
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
			this.dgv1 = new System.Windows.Forms.DataGridView();
			this.save_btn = new System.Windows.Forms.Button();
			this.abort_btn = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.delete_menu = new System.Windows.Forms.ToolStripMenuItem();
			this.refresh_btn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgv1
			// 
			this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv1.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgv1.Location = new System.Drawing.Point(0, 0);
			this.dgv1.MultiSelect = false;
			this.dgv1.Name = "dgv1";
			this.dgv1.RowTemplate.Height = 23;
			this.dgv1.Size = new System.Drawing.Size(1023, 562);
			this.dgv1.TabIndex = 0;
			this.dgv1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv1CellMouseDown);
			this.dgv1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv1CellValueChanged);
			// 
			// save_btn
			// 
			this.save_btn.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.save_btn.Location = new System.Drawing.Point(270, 578);
			this.save_btn.Name = "save_btn";
			this.save_btn.Size = new System.Drawing.Size(90, 31);
			this.save_btn.TabIndex = 1;
			this.save_btn.Text = "存盘";
			this.save_btn.UseVisualStyleBackColor = true;
			this.save_btn.Click += new System.EventHandler(this.Save_btnClick);
			// 
			// abort_btn
			// 
			this.abort_btn.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.abort_btn.Location = new System.Drawing.Point(657, 578);
			this.abort_btn.Name = "abort_btn";
			this.abort_btn.Size = new System.Drawing.Size(82, 31);
			this.abort_btn.TabIndex = 2;
			this.abort_btn.Text = "退出";
			this.abort_btn.UseVisualStyleBackColor = true;
			this.abort_btn.Click += new System.EventHandler(this.Abort_btnClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.delete_menu});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
			// 
			// delete_menu
			// 
			this.delete_menu.Name = "delete_menu";
			this.delete_menu.Size = new System.Drawing.Size(100, 22);
			this.delete_menu.Text = "删除";
			this.delete_menu.Click += new System.EventHandler(this.Record_delete_menuClick);
			// 
			// refresh_btn
			// 
			this.refresh_btn.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.refresh_btn.Location = new System.Drawing.Point(468, 578);
			this.refresh_btn.Name = "refresh_btn";
			this.refresh_btn.Size = new System.Drawing.Size(84, 31);
			this.refresh_btn.TabIndex = 3;
			this.refresh_btn.Text = "刷新";
			this.refresh_btn.UseVisualStyleBackColor = true;
			this.refresh_btn.Click += new System.EventHandler(this.Refresh_btnClick);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1023, 621);
			this.Controls.Add(this.refresh_btn);
			this.Controls.Add(this.abort_btn);
			this.Controls.Add(this.save_btn);
			this.Controls.Add(this.dgv1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button refresh_btn;
		private System.Windows.Forms.ToolStripMenuItem delete_menu;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button abort_btn;
		private System.Windows.Forms.Button save_btn;
		private System.Windows.Forms.DataGridView dgv1;
	}
}
