//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackendFinal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class C_News_category
    {
        public int id { get; set; }
        public string category_name { get; set; }
        public string photo { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public Nullable<System.DateTime> dates { get; set; }
        public string text { get; set; }
        public string pages { get; set; }
        public int type_id { get; set; }
        public int categoryID { get; set; }
    
        public virtual category category { get; set; }
        public virtual type type { get; set; }
    }
}
