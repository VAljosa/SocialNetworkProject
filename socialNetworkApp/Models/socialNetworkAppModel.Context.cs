﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UserFriendsEntities : DbContext
    {
        public UserFriendsEntities()
            : base("name=UserFriendsEntities")
        {
        }
    
        //Ako je generisan sa 'CodeFirst'
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<UserFriend>().ToTable("UserFriend");
            //base.OnModelCreating(modelBuilder);
        }
    
        public virtual DbSet<Friend> Friends { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserFriend> UsersFriends { get; set; }
    }
}