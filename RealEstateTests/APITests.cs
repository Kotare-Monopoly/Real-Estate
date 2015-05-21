using System;
using System.Reflection;
using NUnit.Framework;
using RealEstate.Models;

namespace RealEstateTests
{
    [TestFixture]
    public class APITests
    {
        [Test]
        public void Model_Exists()
        {
            // Arrange
            string expected = "RealEstate.Models.Property, RealEstate";

            // Act
            var actual = Type.GetType(expected);

            // Assert
            Assert.That(actual, Is.Not.Null);
        }

        [Test]
        public void Model_HasProperty_Name()
        {
            // Arrange
            Property sut = new Property();
            string expected = "Name";

            // Act
            Type actual = sut.GetType();

            // Assert
            Assert.That(actual.GetProperty("Name"), Is.Not.Null);
        }
    }
}
