﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Sample_WebAPIEntities : DbContext
    {
        public Sample_WebAPIEntities()
            : base("name=Sample_WebAPIEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<GetAllEmps_Result> GetAllEmps()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllEmps_Result>("GetAllEmps");
        }
    
        public virtual int InsertEmp(string name, ObjectParameter isSaved)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertEmp", nameParameter, isSaved);
        }
    }
}
