using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Угрюмова_практика_7_19_
{
    internal class Student
    {
        registr formreg = new registr();
        string name;
        string group;
        public string[] answer;
        public string Get_name()
        {
            return name = formreg.GetName();
        } 
        public string Get_group()
        {
            return group = formreg.GetGroup();
        }
    }
}
