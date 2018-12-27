using stencilv.Entity.EnumEntity;
using stencilv.Entity.sys;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace stencilv.Entity
{
    /// <summary>
    /// 公共实体类
    /// </summary>
    public class sys_Total
    {
        /// <summary>
        /// 实体类ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 实体类添加时间
        /// </summary>
        public DateTime sys_AddTime { get; set; }
        /// <summary>
        /// 实体类删除状态
        /// </summary>
        public Enum_Delete sys_Delete { get; set; }
        /// <summary>
        /// 添加用户ID
        /// </summary>
        public virtual int? sys_AddUserId { get; set; }
        /// <summary>
        /// 添加用户
        /// </summary>
        [ForeignKey("sys_AddUserId")]
        public sys_User sys_AddUser { get; set; }
        /// <summary>
        /// 实体类是否可用状态
        /// </summary>
        public Enum_State sys_State { get; set; }
        /// <summary>
        /// 备注信息
        /// </summary>
        public string sys_Remarks { get; set; }
        /// <summary>
        /// 备注信息
        /// </summary>
        public string sys_Remarks1 { get; set; }
        /// <summary>
        /// 备注信息
        /// </summary>
        public string sys_Remarks2 { get; set; }

    }
}
