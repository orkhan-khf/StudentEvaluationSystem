//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentEvaluationSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Teacher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teacher()
        {
            this.Groups = new HashSet<Group>();
        }
    
        public int id { get; set; }
        public string teacher_name { get; set; }
        public string teacher_surname { get; set; }
        public string teacher_email { get; set; }
        public int teacher_phone { get; set; }
        public string teacher_photo { get; set; }
        public string teacher_info { get; set; }
        public int teacher_gender_id { get; set; }
        public string teacher_password { get; set; }
    
        public virtual Gender Gender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Group> Groups { get; set; }
    }
}
