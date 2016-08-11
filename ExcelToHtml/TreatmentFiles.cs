/*
 * Created by SharpDevelop.
 * User: Соколов
 * Date: 02.08.2016
 * Time: 12:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace ExcelToHtml
{
	/// <summary>
	/// Description of TreatmentFiles.
	/// </summary>
	public class TreatmentFiles
	{
		public TreatmentFiles()
		{
			
			
		}
		
		public string runTreatment() {
			
		    
			String HtmlText="Update success";
			ListFileExcelOfFolder listFile = new ListFileExcelOfFolder(Settings1.Default.PathIn);
			List<string> ls = listFile.getAllFileFromHolder();
			
			
			String[] array=ls.ToArray();
			if (array.Length>0) {
			
				HtmlConverter converter = new HtmlConverter();
				HtmlText=converter.FromExcelToHtml(array[0]);
			}
			//////
			
			MySqlConnection  con = new MySqlConnection();
			con.ConnectionString=Settings1.Default.ConnectionString;
			MySqlCommand command = new MySqlCommand();
			try {
				con.Open();
			string sqlCommandText="update data set text=@text,dateadd=@dateadd where id=@id";	
			command.Parameters.AddWithValue("@text",HtmlText);
			command.Parameters.AddWithValue("@dateadd",DateTime.Today);
			command.Parameters.AddWithValue("@id",Settings1.Default.IdField);
			                                
			command.Connection=con;
			command.CommandText=sqlCommandText;
			command.ExecuteNonQuery();
			con.Close();
			HtmlText="Information Updated/n";
			
			} catch (Exception e)
			{  
				con.Close();
                return e.StackTrace;         
			}
			
			
			return HtmlText;
			
			
			
			
			
		}
		
	}
}
