/*
 * Created by SharpDevelop.
 * User: Соколов
 * Date: 02.08.2016
 * Time: 17:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExcelToHtml
{
	/// <summary>
	/// Description of SettingFomr.
	/// </summary>
	public partial class SettingForm : Form
	{
		public SettingForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SettingFomrLoad(object sender, EventArgs e)
		{
			label2.Text=Settings1.Default.PathIn;
			richTextBox1.Text=Settings1.Default.ConnectionString;
			textBox1.Text=Settings1.Default.IdField;
			
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folder = new FolderBrowserDialog();
			 DialogResult result = folder.ShowDialog();
			
			if (result==DialogResult.OK) {
		    Settings1.Default.PathIn=folder.SelectedPath;
		    label2.Text=folder.SelectedPath;
		    Settings1.Default.Save();    
			}
		}
		
		
		
		
		void SaveButtonClick(object sender, EventArgs e)
		{
			Settings1.Default.ConnectionString=richTextBox1.Text;
			Settings1.Default.IdField=textBox1.Text;
			Settings1.Default.Save();
			this.Close();
		}
	}
}
