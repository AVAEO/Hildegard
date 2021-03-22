using System;
using System.Collections.Generic;


namespace Htest.Models
{
public class Student {
    public string ID {get;set;}
    public string firstName{get;set;}
    public string secondName {get;set;}
    public List<string> references{get;set;}
    public List<string> subjects{get;set;}
    public string yearGroup{get;set;}
    public string[] certificates{get;set;}
}

}