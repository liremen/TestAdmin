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
    
    public partial class PermissionSpecialBtn
    {
        public PermissionSpecialBtn()
        {
            this.RolePerRelationship = new HashSet<RolePerRelationship>();
        }
    
        public int psbtnId { get; set; }
        public int psbtnMenuId { get; set; }
        public Nullable<int> psbtnPermission { get; set; }
        public string psbtnName { get; set; }
        public string psbtnJsMethodName { get; set; }
        public string psbtnIco { get; set; }
        public int psbtnSort { get; set; }
        public bool psbtnIsDel { get; set; }
        public System.DateTime psbtnAddTime { get; set; }
    
        public virtual PermissionMenu PermissionMenu { get; set; }
        public virtual PermissionMenu PermissionMenu1 { get; set; }
        public virtual ICollection<RolePerRelationship> RolePerRelationship { get; set; }
    }
}
