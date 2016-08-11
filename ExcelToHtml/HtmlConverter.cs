/*
 * Created by SharpDevelop.
 * User: Соколов
 * Date: 02.08.2016
 * Time: 10:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;



namespace ExcelToHtml
{
	/// <summary>
	/// Description of HtmlConverter.
	/// </summary>
	public class HtmlConverter
	{
		public HtmlConverter()
		{
		}
		
		public string FromExcelToHtml(string pathToFile) {
			String htmlDocument="";
			Workbook book = Workbook.Load(pathToFile);
			Worksheet sheet = book.Worksheets[0];
			
			
			
			htmlDocument=htmlDocument+"<div id='yw0' class='grid-view'>";
			htmlDocument=htmlDocument+"<div class='summary'></div>";
			htmlDocument=htmlDocument+"<table class='items'>";
			htmlDocument=htmlDocument+"<thead><tr><th id='yw0_c0' rowspan=2>№<br>п/п</th><th id='yw0_c1' rowspan=2>Субъект Федерации</th><th id='yw0_c2' colspan=2>Работает</th><th id='yw0_c4' colspan=2>Не работает</th></tr><tr><th id='yw0_c2'>Мужчины</th><th id='yw0_c3'>Женщины</th><th id='yw0_c4'>Мужчины</th><th id='yw0_c5'>Женщины</th></tr></thead>";
			htmlDocument=htmlDocument+"<tbody>";
			
			    //// цикл 
			
			   
			    int lastindex= sheet.Cells.LastRowIndex;
			string territory="";
			string value1="";
			string value2="";
			string value3="";
			string value4="";
			int workingMen=0;
			int workingWomen=0;
			int unemployedMen=0;
			int unemployedWomen=0;
			
			int index=0;    
			    
			    
			    for (int rowIndex=8;rowIndex<lastindex;rowIndex++) {
			   
				Row row = sheet.Cells.GetRow(rowIndex);
				for (int colIndex = row.FirstColIndex;
				     colIndex <= row.LastColIndex; colIndex++) 
				{ Cell cell = row.GetCell(colIndex);
				  
					if (colIndex==0) {
						if (cell.IsEmpty) break;
						territory=(String)cell.Value;

						if (territory=="г.Байконур")  
						{break; }
						
						if (territory=="Место жительства не указано")  
						{break; }
						
						index++;
						
						if (territory=="Город Москва столица Российской Федерации город федерального значения") territory="Город Москва";
						if (territory=="Город Санкт-Петербург город федерального значения") territory="Город Санкт-Петербург";
						if (territory=="Ханты-Мансийский автономный округ - Югра (Тюменская область)") territory="Ханты-Мансийский автономный округ";
						if (territory=="Ямало-Ненецкий автономный округ (Тюменская область)") territory="Ямало-Ненецкий автономный округ";
						
						
						if (territory=="ВСЕГО") 
						{
						htmlDocument=htmlDocument+"<tr class='odd'><td align='center'></td>";
						htmlDocument=htmlDocument+"<td>"+territory+"</td>";
						htmlDocument=htmlDocument+"<td align='center'>"+workingMen.ToString()+"</td>";
						htmlDocument=htmlDocument+"<td align='center'>"+workingWomen.ToString()+"</td>";
						htmlDocument=htmlDocument+"<td align='center'>"+unemployedMen.ToString()+"</td>";
						htmlDocument=htmlDocument+"<td align='center'>"+unemployedWomen.ToString()+"</td>";
						break;	
						}
						
						
						htmlDocument=htmlDocument+"<tr class='odd'><td align='center'>"+index.ToString()+"</td>";
						htmlDocument=htmlDocument+"<td>"+territory+"</td>";
						 
						
					}
					
					if (colIndex==1) {
						if (cell.IsEmpty) break;
					    Type type= cell.GetType();
						value1=((Double)cell.Value).ToString();
						htmlDocument=htmlDocument+"<td align='center'>"+value1+"</td>";
						workingMen=workingMen+Convert.ToInt32(value1);
						
					}
					
					if (colIndex==2) {
						if (cell.IsEmpty) break;
						value2=((Double)cell.Value).ToString();
						htmlDocument=htmlDocument+"<td align='center'>"+value2+"</td>";
						workingWomen=workingWomen+Convert.ToInt32(value2);
					}
					if (colIndex==3) {
						if (cell.IsEmpty) break;
						value3=((Double)cell.Value).ToString();
						htmlDocument=htmlDocument+"<td align='center'>"+value3+"</td>";
						unemployedMen=unemployedMen+Convert.ToInt32(value3);
					}
					
					if (colIndex==4) {
						if (cell.IsEmpty) break;
						value4=((Double)cell.Value).ToString();
						htmlDocument=htmlDocument+"<td align='center'>"+value4+"</td>";
						htmlDocument=htmlDocument+"</tr>";
						unemployedWomen=unemployedWomen+Convert.ToInt32(value4);
					}
					
					
				}
			    }
			// конец цикла
			htmlDocument=htmlDocument+"</tbody>";
			htmlDocument=htmlDocument+"</table>";
			htmlDocument=htmlDocument+"</div>";
			
			
			htmlDocument=htmlDocument.Replace("'","\"");
			
			
			
			return htmlDocument;
		}
	}
}
