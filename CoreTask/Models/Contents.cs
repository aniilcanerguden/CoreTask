//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoreTask.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contents
    {
        public int ContentID { get; set; }
        public string ContentValue { get; set; }
        public System.DateTime ContentTime { get; set; }
        public int HeadingID { get; set; }
        public Nullable<int> WriterID { get; set; }
    
        public virtual Headings Headings { get; set; }
        public virtual Writers Writers { get; set; }
    }
}