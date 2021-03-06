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
    
    public partial class Role
    {
        public Role()
        {
            this.Employee = new HashSet<Employee>();
            this.RolePerRelationship = new HashSet<RolePerRelationship>();
            this.WorkFlowNodeRole = new HashSet<WorkFlowNodeRole>();
        }
    
        public int roleId { get; set; }
        public Nullable<int> roleDepId { get; set; }
        public string roleName { get; set; }
        public bool roleIsDel { get; set; }
        public System.DateTime roleAddTime { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<RolePerRelationship> RolePerRelationship { get; set; }
        public virtual ICollection<WorkFlowNodeRole> WorkFlowNodeRole { get; set; }
    }
}
