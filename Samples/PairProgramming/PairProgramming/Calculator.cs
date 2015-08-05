using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramming.BLL
{
    public class Calculator
    {
        //;\n1,2
        // = 3
        public int Add(string num)
        {
            string[] lines = num.Split('\n');
            //;
            //1;2
            int x = 0;
            string delim = ",";
            foreach (var s in lines)
            {
                if (s.StartsWith("//"))
                {
                    delim = s.Replace("//","");
                    continue;
                }
                string[] nums = s.Split(delim.ToCharArray());
                foreach (var s1 in nums)
                {
                    x += int.Parse(s1);
                }
            }
            return x;
        }

    }
}
