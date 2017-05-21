using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace socialNetworkApp.Models
{
    public partial class UserFriend
    {
        public UserFriend()
        {
            this.User = new ObservableCollection<User>();
            this.Friends = new ObservableCollection<Friend>();
        }

        public int IDUser { get; set; }
        public int IDFriends { get; set; }

        public virtual ObservableCollection<User> User { get; set; }
        public virtual ObservableCollection<Friend> Friends{ get; set; }
    }
}