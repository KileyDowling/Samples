using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SGCorpHR.BLL;
using SGCorpHR.Models;

namespace SGCorpHR.TEST
{[TestFixture]
    public class FileOperationsTest
    {
    [Test]
    public void DisplayFiles()
    {
        var ops = new FileOperations();

        var response = ops.DisplayFiles();
        Assert.IsTrue(response.Success);
        Assert.IsNotNull(response.Data);
    }
    }
}
