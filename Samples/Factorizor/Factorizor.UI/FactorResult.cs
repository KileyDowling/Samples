using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor.UI
{
    public class FactorResult
    {
        public List<int> Factors { get; set; }
        public int Number { get; set; }
        public bool IsPrime { get; set; }
        public bool IsPerfect { get; set; }
    }
}
