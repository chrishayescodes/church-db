using System;
using System.IO;
using System.Reflection;
using ChurchDb.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChurchDb.SqLitePersistence.Tests
{
    [TestClass]
    public class TestChurchContactPersistence
    {
        [TestMethod]
        public void TestSave()
        {
            var persistence = new SqliteChurchContactPersistence(()=>DateTime.Now);
            var dbfilename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "test.db");
            if(File.Exists(dbfilename)) File.Delete(dbfilename);
            persistence.Init(dbfilename);
            string id = persistence.Save(new ChurchContact {LastName = "Bubba"});
            Assert.AreEqual(expected: 1, actual: int.Parse(id));

            var contact = persistence.GetById(1.ToString());
            Assert.IsNotNull(contact);
            Assert.AreEqual(expected: "Bubba", actual:contact.LastName);
        }
    }
}