using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyRestfullApp;
using System.Linq;
using MyRestfullApp.Controllers;
using System.Web.Http.Results;

namespace MyRestfullAppTest
{
    [TestClass]
    public class UnitTest1
    {
        private ApiDbEntities db = new ApiDbEntities();

        [TestMethod]
        public void TestGetUsers()
        {
            var users = db.Users.ToList();

            var controller = new UsersController();
            var response = controller.GetUsers();

            Assert.AreEqual(users.Count, response.Count());
        }

        [TestMethod]
        public void GetUser()
        {
            var users = db.Users.ToList();
            var controller = new UsersController();

            var result = controller.GetUser(4) as OkNegotiatedContentResult<User>;
            Assert.IsNotNull(result);
            Assert.AreEqual(users[3].Nombre, result.Content.Nombre);
        }
    }
}
