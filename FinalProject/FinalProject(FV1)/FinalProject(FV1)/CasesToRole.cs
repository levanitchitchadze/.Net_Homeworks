//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject_FV1_
{
    using System;
    using System.Collections.Generic;
    
    public partial class CasesToRole
    {
        public int UserId { get; set; }
        public int CaseId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual TestCas TestCas { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}