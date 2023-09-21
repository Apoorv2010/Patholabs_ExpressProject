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

        public void Return_Credentials()
        {
            Return_Credentials(service);
        }

        private void Return_Credentials(User_ApplicationService service)
        {
            throw new NotImplementedException();
        }
    }
}
