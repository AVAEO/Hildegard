// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;
// using Htest.Models;
// using System.IO;
// using OfficeOpenXml;

// namespace Htest.Data{
    
//     public class ExcelHelperOld{
//         private string filepath = @"Hildegard Test Data v2.xlsx";

//         public List<List<string>> ReadData(int sheet)
//         {
//             ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
//             //provide file path
//             FileInfo existingFile = new FileInfo(filepath);
//             //use EPPlus
//             using (ExcelPackage package = new ExcelPackage(existingFile))
//             {
//                 //get the first worksheet in the workbook
//                 ExcelWorksheet worksheet = package.Workbook.Worksheets[sheet];
//                 int colCount = worksheet.Dimension.End.Column;  //get Column Count
//                 int rowCount = worksheet.Dimension.End.Row;     //get row count
//                 List<List<string>> data = new List<List<string>>();
//                 for (int row = 1; row <= rowCount; row++)
//                 {
//                     List<string> rowData = new List<string>();
//                     for (int col = 1; col <= colCount; col++)
//                     {
//                         string tileData = worksheet.Cells[row, col].Value?.ToString().Trim();
//                         rowData.Add(tileData);
//                     }  
//                     data.Add(rowData);
//                 }
//                 return data;
//             }
//         }

//     public List<HClass> GetAllClassesForTeacher(string name){
        
//             var teacherLines = ReadData(0);
//             //List<Teacher> teachers = new List<Teacher>();
//             if (teacherLines != null)
//             {
//                 List<HClass> teacherClasses = new List<HClass>();
//                 foreach (var line in teacherLines)
//                 {    
//                     if (line != null){
                        
//                         if (name == line[0])
//                         {
//                             var reference = line[1];
//                             //Guid ID = Guid.NewGuid();
//                             int ID = 0;
//                             HClass TeacherClass = new HClass{                  
//                                 Id = ID,
//                                 Name = reference,
//                                 Teacher = name,
//                             };
//                             teacherClasses.Add(TeacherClass); 
//                         }   
//                     }                    
//                 }
//                 return teacherClasses;
//             }
//             else{
//                 return null;
//             }

//         }

//         public List<Student> GetStudentsForClass(string classReference){
//             var studentLines = ReadData(1);
//             if (studentLines != null)
//             {
//                 List<Student> students = new List<Student>();
//                 foreach (var line in studentLines)
//                 {
//                     if (line != null)
//                     {
//                         if (classReference == line[3])
//                         {
//                             Student student = new Student{                  
//                                 ID = line[0],
//                                 firstName = line[1],
//                                 secondName = line[2],
//                                 //references = references,
//                                 //subjects = subjects,
//                                 yearGroup = line[5]
//                                 };

//                             students.Add(student);
//                         }
//                     }
//                 }
//                 return students;
//             }
//             else{
//                 return null;
//             }
//         }
//         public List<Teacher> GetAllTeachers(){
        
//             var teacherLines = ReadData(0);
//             List<Teacher> teachers = new List<Teacher>();
//             if (teacherLines != null)
//             {
//                 for (int i = 1; i < teacherLines.Count; i++)
//                 {
//                     List<string> line = teacherLines[i];
//                     if (line != null){
//                         string name = line[0];
//                         List<string> references = new List<string>();
//                         while (name == line[0])
//                         {
//                             references.Add(line[1]);
//                             try{
//                                 if (teacherLines[i+1][0] == name)
//                                 {
//                                     i++;
//                                     line = teacherLines[i];
//                                 }
//                                 else{break;}
//                             }
//                             catch(Exception)
//                             {
//                                 break;
//                             }                            
//                         }
//                         Guid ID = Guid.NewGuid();
//                         Teacher teacher = new Teacher{                  
//                         ID = ID,
//                         name = line[0],
//                         references = references,
//                         };
//                         teachers.Add(teacher); 
//                     } 
                    
//                 }
//                 return teachers;
//             }
//             else{
//                 return null;
//             }

//         }
        
//     }
// }