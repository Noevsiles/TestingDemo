using MyLibrary;
using NUnit.Framework;

namespace MyLibraryTest
{
    [TestFixture]
    public class CustomerNunitTest
    {
        public void Fullname_ReturnFullName()
        {

            //1. arrange
            Customer customer = new Customer();

            //2. Act
            String result = customer.FullName;

            //3. Assert
            Assert.That(String.IsNullOrWhiteSpace(result), Is.True);
        }
        [Test]
        public void FullName_ReturnFullName() {
            //1. Arrange
            Customer customer = new Customer
            {
                FirstName = "John",
                LastName = "Doe"
            };

            //2. Act
            String result = customer.FullName;

            //3. Assert
            Assert.That(result, Is.Not.WhiteSpace);
            Assert.That(result, Does.Contain(" "));
            Assert.That(result, Does.Contain("John"));
            Assert.That(result, Does.Contain("Doe"));
            Assert.That(result, Does.StartWith("John"));
            Assert.That(result, Does.EndWith("Doe"));
            Assert.That(result, Is.EqualTo("John Doe"));
            Assert.That(result, Is.EqualTo("john doe").IgnoreCase);

        }
    }

    }
