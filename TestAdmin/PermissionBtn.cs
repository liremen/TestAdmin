//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestAdmin
{
    using System;
    using System.Collections.Generic;
    
    public partial class PermissionBtn
    {
        public PermissionBtn()
        {
            this.PerBtnRelationship = new HashSet<PerBtnRelationship>();
            this.RolePerRelationship = new HashSet<RolePerRelationship>();
        }
    
        public int perbtnId { get; set; }
        public string perbtnName { get; set; }
        public string perbtnJsMethodName { get; set; }
        public string perbtnIco { get; set; }
        public bool perbtnIsShow { get; set; }
        public int perbtnOrder { get; set; }
        public bool perbtnIsDel { get; set; }
        public System.DateTime perbtnAddTime { get; set; }
    
        public virtual ICollection<PerBtnRelationship> PerBtnRelationship { get; set; }
        public virtual ICollection<RolePerRelationship> RolePerRelationship { get; set; }
    }
}
