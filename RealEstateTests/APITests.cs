using System;
using NUnit.Framework;

namespace RealEstateTests
{
    [TestFixture]
    public class APITests
    {
        [Test]
        public void Model_Exists()
        {
            // Arrange
            string expected = "RealEstate.Property";

            // Act
            var actual = Type.GetType(expected);

            // Assert
            Assert.That(actual, Is.Not.Null);
        }
    }
}
