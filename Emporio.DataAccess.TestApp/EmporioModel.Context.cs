﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Emporio.DataAccess.TestApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EmporioDemoEntities : DbContext
    {
        public EmporioDemoEntities()
            : base("name=EmporioDemoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CatalogItem> CatalogItems { get; set; }
        public virtual DbSet<ShoppingList> ShoppingLists { get; set; }
        public virtual DbSet<ShoppingListItem> ShoppingListItems { get; set; }
    }
}