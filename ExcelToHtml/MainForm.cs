/*
 * Created by SharpDevelop.
 * User: Соколов
 * Date: 01.08.2016
 * Time: 17:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ExcelToHtml
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
		}
		
		void FolderInToolStripMenuItemClick(object sender, EventArgs e)
		{
			FolderBrowserDialog folder = new FolderBrowserDialog();
			 DialogResult result = folder.ShowDialog();
			
			if (result==DialogResult.OK) {
		    Settings1.Default.PathIn=folder.SelectedPath;
		    Settings1.Default.Save();
		    
			}
		}
		
		void StartStopClick(object sender, EventArgs e)
		{
			TreatmentFiles files= new TreatmentFiles();
		    richTextBox1.Text=files.runTreatment();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
		 label1.Text=Settings1.Default.PathIn;
		}
		
		void SettingToolStripMenuItem1Click(object sender, EventArgs e)
		{
			SettingForm form = new SettingForm();
			form.ShowDialog();
		}
	}
}
