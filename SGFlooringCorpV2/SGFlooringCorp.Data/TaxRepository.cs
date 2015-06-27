using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGFlooringCorp.Models;
using SGFlooringCorp.Models.Interfaces;

namespace SGFlooringCorp.Data
{
    public class TaxRepository : IStateTaxRepository
    {
        public List<StateTax> ListAll()
        {
            List<StateTax> stateTaxes = new List<StateTax>();

          const string FilePath = @"DataFiles\Taxes.txt";
            if(File.Exists(FilePath))
            {
                var reader = File.ReadAllLines(FilePath);
                  for (int i = 1; i < reader.Length; i++)
                {
                    var columns = reader[i].Split(',');

                    var taxRate = new StateTax();
                    taxRate.StateAbbreviation =  columns[0];
                    taxRate.TaxRate = decimal.Parse(columns[1]);

                    stateTaxes.Add(taxRate);
                }		    
                return stateTaxes;
            }
            return null;

        }

    }
}
