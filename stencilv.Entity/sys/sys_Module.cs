namespace stencilv.Entity.sys
{
    /// <summary>
    /// 模块管理
    /// </summary>
    public class sys_Module : sys_Total
    {
        /// <summary>
        /// 模块名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 层级
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public string Sort { get; set; }
        /// <summary>
        /// 上级
        /// </summary>
        public string Superior { get; set; }
    }
}
