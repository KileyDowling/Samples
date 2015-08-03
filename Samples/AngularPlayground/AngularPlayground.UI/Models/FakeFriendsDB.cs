using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;

namespace AngularPlayground.UI.Models
{
    public class FakeFriendsDb
    {
        private static readonly List<Friend> _friends = new List<Friend>();

        static FakeFriendsDb()
        {
            _friends.AddRange(new[]
            {
             new Friend() {Age=32, Name="Jenny", Phone = "875-2555"},   
             new Friend() {Age=33, Name="Joe", Phone = "555-2555"},   
             new Friend() {Age=34, Name="Jesse", Phone = "222-2555"},
             new Friend() {Age=35, Name="Rylie", Phone = "666-2555"}      
            });
        }

        public List<Friend> GetAll()
        {
            return _friends;  
        }

        public void Add(Friend friend)
        {
            _friends.Add(friend);
        }
    }
}
   