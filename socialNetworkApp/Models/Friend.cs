//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace socialNetworkApp.Models
{
    using System;
    using System.Collections.ObjectModel;
    
    public partial class Friend
    {
       
        public Friend()
        {
            this.Users = new ObservableCollection<User>();
        }
    
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public Nullable<int> Age { get; set; }
        public string Gender { get; set; }
    
        
        public virtual ObservableCollection<User> Users { get; set; }
    }
}
