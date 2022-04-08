//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Student_Registration
    {
        public Student_Registration()
        {
            this.Student_Payments = new HashSet<Student_Payments>();
        }
    
        public int registration_id { get; set; }
        public Nullable<int> student_id { get; set; }
        public Nullable<int> registration_code { get; set; }
        public Nullable<int> course_id { get; set; }
        public Nullable<System.DateTime> registration_date { get; set; }
    
        public virtual Course_Details Course_Details { get; set; }
        public virtual Student_Details Student_Details { get; set; }
        public virtual ICollection<Student_Payments> Student_Payments { get; set; }
    }
}
