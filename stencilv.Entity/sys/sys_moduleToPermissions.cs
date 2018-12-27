using System.ComponentModel.DataAnnotations.Schema;

namespace stencilv.Entity.sys
{
    /// <summary>
    /// 模块权限表
    /// </summary>
    public class sys_moduleToPermissions
    {
        /// <summary>
        /// 权限关系表ID
        /// </summary>
        public virtual int? sys_permissionsId { get; set; }
        /// <summary>
        /// 权限关系表
        /// </summary>
        [ForeignKey("sys_permissionsId")]
        public sys_Permissions sys_permissions { get; set; }
        /// <summary>
        /// 模块关系表ID
        /// </summary>
        public virtual int? sys_ModeulId { get; set; }
        /// <summary>
        /// 模块关系表
        /// </summary>
        [ForeignKey("sys_ModeulId")]
        public sys_Module sys_Modeul { get; set; }
    }
}
