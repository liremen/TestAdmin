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
    
    public partial class PermissionMenu
    {
        public PermissionMenu()
        {
            this.PerBtnRelationship = new HashSet<PerBtnRelationship>();
            this.PerBtnRelationship1 = new HashSet<PerBtnRelationship>();
            this.PermissionSpecialBtn = new HashSet<PermissionSpecialBtn>();
            this.RolePerRelationship = new HashSet<RolePerRelationship>();
            this.PermissionSpecialBtn1 = new HashSet<PermissionSpecialBtn>();
        }
    
        public int perId { get; set; }
        public int perParent { get; set; }
        public string perName { get; set; }
        public string perRemark { get; set; }
        public string perAreaName { get; set; }
        public string perControllerName { get; set; }
        public string perActionName { get; set; }
        public short perFormMethod { get; set; }
        public short perOperationType { get; set; }
        public string perIco { get; set; }
        public bool perIsLink { get; set; }
        public int perOrder { get; set; }
        public bool perIsShow { get; set; }
        public bool perIsDel { get; set; }
        public System.DateTime perAddTime { get; set; }
    
        public virtual ICollection<PerBtnRelationship> PerBtnRelationship { get; set; }
        public virtual ICollection<PerBtnRelationship> PerBtnRelationship1 { get; set; }
        public virtual ICollection<PermissionSpecialBtn> PermissionSpecialBtn { get; set; }
        public virtual ICollection<RolePerRelationship> RolePerRelationship { get; set; }
        public virtual ICollection<PermissionSpecialBtn> PermissionSpecialBtn1 { get; set; }
    }
}