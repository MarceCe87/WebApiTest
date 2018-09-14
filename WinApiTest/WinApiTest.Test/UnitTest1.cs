using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinApiTest.Controllers;
using System.Linq;
using System.Web.Http.Results;
using WinApiTest;

namespace WinApiTest.Test
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
