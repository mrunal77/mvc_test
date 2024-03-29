﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FullCodeBasedTest.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DemoDatabaseEntities : DbContext
    {
        public DemoDatabaseEntities()
            : base("name=DemoDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblCity> TblCities { get; set; }
        public virtual DbSet<TblPerson> TblPersons { get; set; }
    
        public virtual int sp_insert_City(Nullable<int> cityId, string cityName)
        {
            var cityIdParameter = cityId.HasValue ?
                new ObjectParameter("CityId", cityId) :
                new ObjectParameter("CityId", typeof(int));
    
            var cityNameParameter = cityName != null ?
                new ObjectParameter("CityName", cityName) :
                new ObjectParameter("CityName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_insert_City", cityIdParameter, cityNameParameter);
        }
    
        public virtual int sp_insert_Person(Nullable<int> id, string name, string email, string mobile, string course, string percentage, string address, Nullable<int> city)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(string));
    
            var courseParameter = course != null ?
                new ObjectParameter("Course", course) :
                new ObjectParameter("Course", typeof(string));
    
            var percentageParameter = percentage != null ?
                new ObjectParameter("Percentage", percentage) :
                new ObjectParameter("Percentage", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var cityParameter = city.HasValue ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_insert_Person", idParameter, nameParameter, emailParameter, mobileParameter, courseParameter, percentageParameter, addressParameter, cityParameter);
        }
    
        public virtual ObjectResult<sp_viewcity_Result> sp_viewcity()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_viewcity_Result>("sp_viewcity");
        }
    
        public virtual ObjectResult<sp_viewperson_Result> sp_viewperson()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_viewperson_Result>("sp_viewperson");
        }
    
        public virtual ObjectResult<TblPerson> Fun_InsertPerson(Nullable<int> id, string name, string email, string mobile, string course, string percentage, string address, Nullable<int> city)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(string));
    
            var courseParameter = course != null ?
                new ObjectParameter("Course", course) :
                new ObjectParameter("Course", typeof(string));
    
            var percentageParameter = percentage != null ?
                new ObjectParameter("Percentage", percentage) :
                new ObjectParameter("Percentage", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var cityParameter = city.HasValue ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TblPerson>("Fun_InsertPerson", idParameter, nameParameter, emailParameter, mobileParameter, courseParameter, percentageParameter, addressParameter, cityParameter);
        }
    
        public virtual ObjectResult<TblPerson> Fun_InsertPerson(Nullable<int> id, string name, string email, string mobile, string course, string percentage, string address, Nullable<int> city, MergeOption mergeOption)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(string));
    
            var courseParameter = course != null ?
                new ObjectParameter("Course", course) :
                new ObjectParameter("Course", typeof(string));
    
            var percentageParameter = percentage != null ?
                new ObjectParameter("Percentage", percentage) :
                new ObjectParameter("Percentage", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var cityParameter = city.HasValue ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TblPerson>("Fun_InsertPerson", mergeOption, idParameter, nameParameter, emailParameter, mobileParameter, courseParameter, percentageParameter, addressParameter, cityParameter);
        }
    
        public virtual ObjectResult<TblPerson> Fun_ViewPersons()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TblPerson>("Fun_ViewPersons");
        }
    
        public virtual ObjectResult<TblPerson> Fun_ViewPersons(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TblPerson>("Fun_ViewPersons", mergeOption);
        }
    
        public virtual ObjectResult<TblCity> Fun_ViewCity()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TblCity>("Fun_ViewCity");
        }
    
        public virtual ObjectResult<TblCity> Fun_ViewCity(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TblCity>("Fun_ViewCity", mergeOption);
        }
    
        public virtual ObjectResult<TblCity> Fun_InsertCity(Nullable<int> cityId, string cityName)
        {
            var cityIdParameter = cityId.HasValue ?
                new ObjectParameter("CityId", cityId) :
                new ObjectParameter("CityId", typeof(int));
    
            var cityNameParameter = cityName != null ?
                new ObjectParameter("CityName", cityName) :
                new ObjectParameter("CityName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TblCity>("Fun_InsertCity", cityIdParameter, cityNameParameter);
        }
    
        public virtual ObjectResult<TblCity> Fun_InsertCity(Nullable<int> cityId, string cityName, MergeOption mergeOption)
        {
            var cityIdParameter = cityId.HasValue ?
                new ObjectParameter("CityId", cityId) :
                new ObjectParameter("CityId", typeof(int));
    
            var cityNameParameter = cityName != null ?
                new ObjectParameter("CityName", cityName) :
                new ObjectParameter("CityName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TblCity>("Fun_InsertCity", mergeOption, cityIdParameter, cityNameParameter);
        }
    }
}
