using System;
using System.Collections.Generic;
using System.Text;
using DAL;
namespace BUS
{
    public class Tool
    {
        public Tool() { }

        public string RemoveUnicodeBus(string txt)
        {
            return new RemoveUnicode().RemoveUnicodeTool(txt);
        }
    }
}
