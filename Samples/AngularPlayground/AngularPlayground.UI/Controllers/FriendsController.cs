using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularPlayground.UI.Models;

namespace AngularPlayground.UI.Controllers
{
    public class FriendsController : ApiController
    {
        public List<Friend> Get()
        {
            var db = new FakeFriendsDb();
            return db.GetAll();
        }

        public HttpResponseMessage Post(Friend friend)
        {
            var db  = new FakeFriendsDb();
            db.Add(friend);
            
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

    }
}
