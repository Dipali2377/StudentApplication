﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentApplication.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Student_ApplicatinDBEntities : DbContext
    {
        public Student_ApplicatinDBEntities()
            : base("name=Student_ApplicatinDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course_Details> Course_Details { get; set; }
        public virtual DbSet<Student_Details> Student_Details { get; set; }
        public virtual DbSet<Student_Payments> Student_Payments { get; set; }
        public virtual DbSet<Student_Qualification> Student_Qualification { get; set; }
        public virtual DbSet<Student_Registration> Student_Registration { get; set; }
    }
}
