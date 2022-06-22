﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MoayadAPI.Models
{
    public partial class UserInfo
    {
        public UserInfo()
        {
            Items = new HashSet<Item>();
            ItemsBalances = new HashSet<ItemsBalance>();
            Privilages = new HashSet<Privilage>();
            Stores = new HashSet<Store>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<ItemsBalance> ItemsBalances { get; set; }
        public virtual ICollection<Privilage> Privilages { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}