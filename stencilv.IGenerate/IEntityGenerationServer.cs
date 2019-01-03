using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace stencilv.IGenerate
{
    /// <summary>
    /// 实体类操作
    /// </summary>
    public interface IEntityGenerationServer
    {
        /// <summary>
        /// 生成实体类
        /// </summary>
        /// <param name="Name">实体类名称</param>
        /// <param name="json">实体类值</param>
        /// <returns></returns>
        Task<string> GetGenerationEntity(string Name,string json); 
    }
}
