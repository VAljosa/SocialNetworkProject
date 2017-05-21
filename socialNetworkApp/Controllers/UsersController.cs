using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using socialNetworkApp.Models;
using System.Runtime.Remoting.Contexts;


namespace socialNetworkApp.Controllers
{
    public class UsersController : Controller
    {
        private  UserFriendsEntities db = new UserFriendsEntities();

        // GET: List of Users
        [HttpGet]
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        //U slucaju da je Entity detached
        public void Add(UserFriend us)
        {
            db.Set<UserFriend>().Add(us);
        }


        // GET: Users/Friends/5
        public ActionResult Friends(int? id)
        {          

            var friendQuery = from f in db.Friends
                              join uf in db.UsersFriends
                              on f.Id equals uf.IDFriends
                              join u in db.Users
                              on uf.IDUser equals u.Id
                              where u.Id == id
                              select new { f.Id };                                                                                         
                              
            return View(friendQuery.ToList());

        }
     
        // GET: Users/FriendsOfFriends/5
        public ActionResult friendsOfFriends(int? id)
        {
            return null;
        }

        
    }
}
