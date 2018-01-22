﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookReviewMVC2018W.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BookReviewDbEntities : DbContext
    {
        public BookReviewDbEntities()
            : base("name=BookReviewDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CheckinLog> CheckinLogs { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Reviewer> Reviewers { get; set; }
    
        public virtual int usp_NewReviewer(string reviewerUserName, string reviewerFirstName, string reviewerLastName, string reviewerEmail, string reviewPlainPassword)
        {
            var reviewerUserNameParameter = reviewerUserName != null ?
                new ObjectParameter("ReviewerUserName", reviewerUserName) :
                new ObjectParameter("ReviewerUserName", typeof(string));
    
            var reviewerFirstNameParameter = reviewerFirstName != null ?
                new ObjectParameter("ReviewerFirstName", reviewerFirstName) :
                new ObjectParameter("ReviewerFirstName", typeof(string));
    
            var reviewerLastNameParameter = reviewerLastName != null ?
                new ObjectParameter("ReviewerLastName", reviewerLastName) :
                new ObjectParameter("ReviewerLastName", typeof(string));
    
            var reviewerEmailParameter = reviewerEmail != null ?
                new ObjectParameter("ReviewerEmail", reviewerEmail) :
                new ObjectParameter("ReviewerEmail", typeof(string));
    
            var reviewPlainPasswordParameter = reviewPlainPassword != null ?
                new ObjectParameter("ReviewPlainPassword", reviewPlainPassword) :
                new ObjectParameter("ReviewPlainPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_NewReviewer", reviewerUserNameParameter, reviewerFirstNameParameter, reviewerLastNameParameter, reviewerEmailParameter, reviewPlainPasswordParameter);
        }
    
        public virtual int usp_ReviewerLogin(string reviewerUserName, string reviewerPassword)
        {
            var reviewerUserNameParameter = reviewerUserName != null ?
                new ObjectParameter("ReviewerUserName", reviewerUserName) :
                new ObjectParameter("ReviewerUserName", typeof(string));
    
            var reviewerPasswordParameter = reviewerPassword != null ?
                new ObjectParameter("ReviewerPassword", reviewerPassword) :
                new ObjectParameter("ReviewerPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ReviewerLogin", reviewerUserNameParameter, reviewerPasswordParameter);
        }
    }
}
