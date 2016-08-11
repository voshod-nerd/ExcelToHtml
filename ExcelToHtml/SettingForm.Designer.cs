/*
 * Created by SharpDevelop.
 * User: Соколов
 * Date: 02.08.2016
 * Time: 17:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ExcelToHtml
{
	partial class SettingForm
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
			this.ChangePathIn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SaveSettingButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ChangePathIn
			// 
			this.ChangePathIn.BackColor = System.Drawing.SystemColors.Info;
			this.ChangePathIn.Location = new System.Drawing.Point(13, 56);
			this.ChangePathIn.Name = "ChangePathIn";
			this.ChangePathIn.Size = new System.Drawing.Size(392, 23);
			this.ChangePathIn.TabIndex = 0;
			this.ChangePathIn.Text = "Изменить путь";
			this.ChangePathIn.UseVisualStyleBackColor = false;
			this.ChangePathIn.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(393, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Путь до директирии с файлом";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(393, 23);
			this.label2.TabIndex = 2;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 117);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(393, 81);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(393, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Строка соединения с MySql";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 205);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "ID записи";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(13, 232);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(392, 20);
			this.textBox1.TabIndex = 6;
			// 
			// SaveSettingButton
			// 
			this.SaveSettingButton.BackColor = System.Drawing.SystemColors.Info;
			this.SaveSettingButton.Location = new System.Drawing.Point(12, 278);
			this.SaveSettingButton.Name = "SaveSettingButton";
			this.SaveSettingButton.Size = new System.Drawing.Size(393, 31);
			this.SaveSettingButton.TabIndex = 7;
			this.SaveSettingButton.Text = "Сохранить";
			this.SaveSettingButton.UseVisualStyleBackColor = false;
			this.SaveSettingButton.Click += new System.EventHandler(this.SaveButtonClick);
			// 
			// SettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(436, 333);
			this.Controls.Add(this.SaveSettingButton);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ChangePathIn);
			this.Name = "SettingForm";
			this.Text = "SettingFomr";
			this.Load += new System.EventHandler(this.SettingFomrLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button SaveSettingButton;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ChangePathIn;
	}
}
