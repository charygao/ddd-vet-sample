﻿using System;
using System.Collections.Generic;
using FrontDesk.Core.Model.ClientAggregate;
using FrontDesk.Core.Model.PatientAggregate;
using System.Collections;
using NUnit.Framework;

namespace FrontDesk.UnitTests.Model
{
    [TestFixture]
    public class ClientShould
    {
        [Test]
        public void HaveAFewNameProperties()
        {
            var client = new Client();
            string firstName = "Test First Name";
            string lastName = "Test Last Name";
            string salutation = "Mr.";
            string preferredName = "Billy Joe";

            client.FirstName = firstName;
            client.LastName = lastName;
            client.Salutation = salutation;
            client.PreferredName = preferredName;

            Assert.AreEqual(firstName, client.FirstName);
            Assert.AreEqual(lastName, client.LastName);
            Assert.AreEqual(salutation, client.Salutation);
            Assert.AreEqual(preferredName, client.PreferredName);
        }

        [Test]
        public void ReturnFormattedNameWithAllFieldsAsToString()
        {
            var client = new Client()
            {
                FirstName = "Steven",
                LastName = "Smith",
                Salutation = "Mr.",
                PreferredName = "Steve"
            };

            var expectedResult = "Mr. Steven \"Steve\" Smith";

            Assert.AreEqual(expectedResult, client.ToString());
        }

        [Test]
        public void ReturnFormattedNameWithNoPreferredNameAsToString()
        {
            var client = new Client()
            {
                FirstName = "Steven",
                LastName = "Smith",
                Salutation = "Mr."
            };

            var expectedResult = "Mr. Steven Smith";

            Assert.AreEqual(expectedResult, client.ToString());
        }

        [Test]
        public void HaveAListOfPatients()
        {
            var client = new Client();

            var patients = client.Patients;

            Assert.IsNotNull(patients as IList<PatientInfo>);
        }
    }
}
