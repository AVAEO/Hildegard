using System;
using System.Collections.Generic;

namespace Htest.Models
{
public class Teacher {
    public Guid ID {get;set;}
    public string name{get;set;}
    public List<string> references{get;set;}
}

}