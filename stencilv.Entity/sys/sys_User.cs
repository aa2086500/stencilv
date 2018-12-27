using stencilv.Entity.EnumEntity;

namespace stencilv.Entity.sys
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class sys_User : sys_Total
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 帐号
        /// </summary>
        public string UserAccount { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string UserPassword { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public Enum_Age UserAge { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int UserGender { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string UserPhone { get; set; }
    }
}
