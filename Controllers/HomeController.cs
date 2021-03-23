using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Htest.Models;
using System.IO;
using OfficeOpenXml;

namespace Htest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Students()
        {
            List<List<string>> studentLines = ReadDataFromExcel(1);
            //string fileName = "Test.csv";
            List<Student> students = new List<Student>();
            //string[] lines = getLines(fileName);
            if (studentLines != null)
            {
                for (int i = 1; i < studentLines.Count; i++)
                {
                    List<string> line = studentLines[i];
                    if (line != null)
                    {
                        string ID = line[0];
                        List<string> subjects = new List<string>();
                        List<string> references = new List<string>();
                        while (ID == line[0])
                        {
                            subjects.Add(line[4]);
                            references.Add(line[3]);
                            try{
                                if (studentLines[i+1][0] == ID)
                                {
                                    i++;
                                    line = studentLines[i];
                                }
                                else{break;} 
                            }
                            catch(Exception)
                            {
                                break;
                            }        
                        }
                        Student student = new Student{                  
                        ID = ID,
                        firstName = line[1],
                        secondName = line[2],
                        references = references,
                        subjects = subjects,
                        yearGroup = line[5]
                        };
                        students.Add(student); 
                    } 
                }
            }   
            else
            {
                Console.WriteLine("File not found");
            }  
            return View(students);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        } 
            
        
        public static List<List<string>> ReadDataFromExcel(int sheet)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            //provide file path
            FileInfo existingFile = new FileInfo(@"Hildegard Test Data v2.xlsx");
            //use EPPlus
            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                //get the first worksheet in the workbook
                ExcelWorksheet worksheet = package.Workbook.Worksheets[sheet];
                int colCount = worksheet.Dimension.End.Column;  //get Column Count
                int rowCount = worksheet.Dimension.End.Row;     //get row count
                List<List<string>> data = new List<List<string>>();
                for (int row = 1; row <= rowCount; row++)
                {
                    List<string> rowData = new List<string>();
                    for (int col = 1; col <= colCount; col++)
                    {
                        string tileData = worksheet.Cells[row, col].Value?.ToString().Trim();
                        rowData.Add(tileData);
                    }  
                    data.Add(rowData);
                }
                return data;
            }
        }
    }
}
