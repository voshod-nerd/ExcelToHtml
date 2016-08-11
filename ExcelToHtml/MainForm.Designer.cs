/*
 * Created by SharpDevelop.
 * User: Соколов
 * Date: 01.08.2016
 * Time: 17:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ExcelToHtml
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
			this.StartStop = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.folderInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// StartStop
			// 
			this.StartStop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.StartStop.Location = new System.Drawing.Point(112, 47);
			this.StartStop.Name = "StartStop";
			this.StartStop.Size = new System.Drawing.Size(149, 38);
			this.StartStop.TabIndex = 0;
			this.StartStop.Text = "Старт";
			this.StartStop.UseVisualStyleBackColor = false;
			this.StartStop.Click += new System.EventHandler(this.StartStopClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.settingToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(376, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// settingToolStripMenuItem
			// 
			this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.folderInToolStripMenuItem,
									this.settingToolStripMenuItem1});
			this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
			this.settingToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.settingToolStripMenuItem.Text = "Setting";
			// 
			// folderInToolStripMenuItem
			// 
			this.folderInToolStripMenuItem.Name = "folderInToolStripMenuItem";
			this.folderInToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.folderInToolStripMenuItem.Text = "FolderIn";
			this.folderInToolStripMenuItem.Click += new System.EventHandler(this.FolderInToolStripMenuItemClick);
			// 
			// settingToolStripMenuItem1
			// 
			this.settingToolStripMenuItem1.Name = "settingToolStripMenuItem1";
			this.settingToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.settingToolStripMenuItem1.Text = "Setting";
			this.settingToolStripMenuItem1.Click += new System.EventHandler(this.SettingToolStripMenuItem1Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 91);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(337, 200);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 312);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(351, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(376, 359);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.StartStop);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "ExcelToHtml";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ToolStripMenuItem folderInToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Button StartStop;
	}
}
