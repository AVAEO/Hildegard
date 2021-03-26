using System;
using System.Collections.Generic;
using System.Text;
// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System.IO;
using Htest.Models;
using Htest.Data;

namespace Htest.Data
{
    public class Helpers
    {
        

         public List<Teacher> GetTeachers() {
            var helper = new ExcelHelper();
            List<List<string>> teacherLines = helper.ReadDataFromExcel(0);
            List<Teacher> teachers = new List<Teacher>();
            if (teacherLines != null)
            {
                for (int i = 1; i < teacherLines.Count; i++)
                {
                    List<string> line = teacherLines[i];
                    if (line != null){
                        string name = line[0];
                        List<string> references = new List<string>();
                        while (name == line[0])
                        {
                            references.Add(line[1]);
                            try{
                                if (teacherLines[i+1][0] == name)
                                {
                                    i++;
                                    line = teacherLines[i];
                                }
                                else{break;}
                            }
                            catch(Exception)
                            {
                                break;
                            }                            
                        }
                        Guid ID = Guid.NewGuid();
                        Teacher teacher = new Teacher{                  
                        ID = ID,
                        name = line[0],
                        references = references,
                        };
                        teachers.Add(teacher); 
                    } 
                    
                }
                return teachers;
            }   
            else
            {
                Console.WriteLine("File not found");
                return null;
            }  
        }

        public Teacher GetTeacher(string teacherName) {
            var helper = new ExcelHelper();
            List<List<string>> teacherLines = helper.ReadTeacherFromExcel(0, teacherName);
            List<Teacher> teachers = new List<Teacher>();
            if (teacherLines != null)
            {
                string name = teacherLines[0][0];
                List<string> references = new List<string>();
                foreach(var line in teacherLines)
                {
                    if (line != null) {
                        references.Add(line[1]);                            
                        
                    } 
                    
                }
                Guid ID = Guid.NewGuid();
                Teacher teacher = new Teacher{                  
                    ID = ID,
                    name = name,
                    references = references,
                };
                
                return teacher;
            }   
            else
            {
                Console.WriteLine("Teacher not found");
                return null;
            }  
        }


        public List<Student> GetStudents() {
            var helper = new ExcelHelper();
            List<List<string>> studentLines = helper.ReadDataFromExcel(1);
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
                return students;
            }   
            else
            {
                Console.WriteLine("File not found");
                return null;
            }  
        }



        public List<Student> GetStudents(string classRef) {
            var helper = new ExcelHelper();
            List<List<string>> studentLines = helper.ReadStudentsFromExcel(1, classRef);
            List<Student> students = new List<Student>();
            
            if (studentLines != null)
            {
                foreach (var line in studentLines)
                {
                    
                    if (line != null)
                    {
              
                        Student student = new Student{                  
                            ID = line[0],
                            firstName = line[1],
                            secondName = line[2],
                            references = null,
                            subjects = null,
                            yearGroup = null
                        };
                        students.Add(student); 
                    } 
                }
                return students;
            }   
            else
            {
                Console.WriteLine("File not found");
                return null;
            }  
        }

    }
}
