//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogsMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class blogarticlecategory
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public int Status { get; set; }
        public bool IsDel { get; set; }
        public System.DateTime AddTime { get; set; }
    }
}
