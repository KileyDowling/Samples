using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SGCorpHR.BLL;

namespace SGCorpHR.TEST
{
    [TestFixture]
   public class PolicyDocumentsOperationsTest
   {
        [Test]
        public void GetAllCategoriesTest()
        {
            var ops = new PolicyDocumentsOperations();
            var folderPath = @"C:\Users\Apprentice\Desktop\GitHub\KileyDowling\SGCorpHRV2\SGCorpHR\SGCorpHR.TEST\PolicyDocuments";
            var response = ops.GetAllPolicyDocuments(folderPath);
            Assert.IsTrue(response.Success);

        }
        
       [Test]
       public void GetAllFilesTest()
       {
           var ops = new PolicyDocumentsOperations();
           var filePath = @"C:\Users\Apprentice\Desktop\GitHub\KileyDowling\SGCorpHRV2\SGCorpHR\SGCorpHR.TEST\PolicyDocuments";
           var response = ops.GetAllPolicyDocuments(filePath);
           Assert.IsTrue(response.Success);
       }
    }
}
