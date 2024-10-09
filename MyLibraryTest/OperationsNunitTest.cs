using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    [TestFixture]
    public class OperationsNunitTest
    {
        [Test]
        public void add_imputNumbers_returnNumber()
        {
            // 1 Arrange

            Operations operations = new Operations();
            int n1 = 2;
            int n2 = 5;
            int expectedResult = 7;


            //2 act 

            int result = operations.Add(n1, n2);

            // 3 assert

            Assert.That(result, Is.EqualTo(expectedResult));
            Assert.That(result, Is.Not.EqualTo(expectedResult));
        }

        [TestCase(1, 20)]
        [TestCase(100, 1000)]
        public void GetEvenNumbers_inputRange_ReturnEvenNumbers(int start, int end)
        {
            //1. Arrange
            Operations operations=new();
            int startNumber = start % 2 == 0 ? start : start + 1;
            int endNumber = end % 2 == 0 ? end : end - 1;
            int middleNumber = (startNumber + endNumber) / 2;

            middleNumber = middleNumber % 2 == 0 ? middleNumber : middleNumber + 1;
            //int start = 0;
            //int end = 10;

            //2. Act
            IList<int> result = operations.GetEvenNumbers(start, end);

            //3. Assert
            Assert.That(end - start >= 2, Is.True);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Is.TypeOf<List<int>>());
            Assert.That(result.Count, Is.EqualTo(5));
            Assert.That(result, Has.Exactly(5).Items);
            Assert.That(result, Is.Ordered);

            Assert.That(result, Has.No.All.LessThan(startNumber));
            Assert.That(result, Has.Member(startNumber));
            Assert.That(result, Has.Member(middleNumber));
            Assert.That(result, Has.Member(endNumber));
            Assert.That(result, Has.No.All.GreaterThan(endNumber)); 
            
            Assert.That(result, Has.All.GreaterThanOrEqualTo(0));
            Assert.That(result, Has.All.LessThanOrEqualTo(10));
            // Assert.That(result, Has.All.InRange(startNumber, endNumber));
            Assert.That(result, Is.Unique);

        }
    }
}
