using System;
using System.Collections.Generic;
using System.Text;
using DAL;
namespace BUS
{
    public class Tool
    {
        public Tool()
        {
        }
        public string RemoveUnicodeBus(string chuoi)
        {
            return new RemoveUnicode().RemoveUnicodeTool(chuoi);
        }
    }
}
