/*
 * Created by SharpDevelop.
 * User: Соколов
 * Date: 02.08.2016
 * Time: 12:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;

namespace ExcelToHtml
{
	/// <summary>
	/// Description of ListFileExcelOfFolder.
	/// </summary>
	public class ListFileExcelOfFolder
	{
		private string filePath;
		public ListFileExcelOfFolder(string path)
		{
		filePath=path;
			
		}
		
		public List<String> getAllFileFromHolder() {
			List<string> ls = new List<string>();
			String[]  massiv= Directory.GetFiles(filePath);
			foreach (string x in massiv) 
			{
				string extension =Path.GetExtension(x);
				if (extension==".xls") {ls.Add(x);}
			
			}
			
			return ls;
			
			
		}
		
	}
}
