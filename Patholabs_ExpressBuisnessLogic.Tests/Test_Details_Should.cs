using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Patholabs_Express.BuisnessLogic.Services;

namespace Patholabs_ExpressBuisnessLogic.Tests
{
    [TestFixture]
    class Test_Details_Should
    {

        private Test_DetailsService service;
        [OneTimeSetUp]
        public void Init()
        {
            service = new Test_DetailsService();
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            service.Dispose();
        }



    }
}
