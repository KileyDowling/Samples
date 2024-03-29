﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGFlooringCorp.Data;
using SGFlooringCorp.Models;
using SGFlooringCorp.Models.Interfaces;

namespace SGFlooringCorp.Data.Mocks
{
    public class StateTaxRepositoryMock : IStateTaxRepository
    {
        public List<StateTax> ListAll()
        {
            return new List<StateTax>()
            {
                new StateTax() {StateAbbreviation = "OH", TaxRate = 15M},
                new StateTax() {StateAbbreviation = "PA", TaxRate = 7.5M}
            };
        }
    }
}
