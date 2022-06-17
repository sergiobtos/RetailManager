using RMDataManager.Library.DataAccess;
using RMDataManager.Library.Models;
using System;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace RMDataManager.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        [HttpGet]
        public UserModel GetById()
        {
            string id = RequestContext.Principal.Identity.GetUserId();

            UserData data = new UserData();


            return data.GetUserById(id).First();
        }

    }
}
