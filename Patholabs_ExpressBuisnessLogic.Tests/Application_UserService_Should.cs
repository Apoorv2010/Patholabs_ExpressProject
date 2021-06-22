using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Patholabs_Express.BuisnessLogic.Services;
using Patholabs_Express.DataAccess.Entities;

namespace Patholabs_ExpressBuisnessLogic.Tests
{
    [TestFixture]
    class Application_UserService_Should
    {
        private User_ApplicationService service;
        [OneTimeSetUp]
        public void Init()
        {
            service = new User_ApplicationService();
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            service.Dispose();
        }

        [Test]
        public void Return_All_Users()
        {
            var user = service.GetAll();
            CollectionAssert.IsNotEmpty(user);

        }

        [Test]



        public void Return_Credentials()
        {
            bool log = service.Authenticate("apoorvjain6@gmail.com", "apoorv", enUserType.User);
            bool x = true;
            Assert.AreEqual(x, log);
        }
    }
}
