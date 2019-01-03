using stencilv.IGenerate;
using System.Threading.Tasks;

namespace stencilv.Generate
{
    public class EntityGenerationServer : IEntityGenerationServer
    {
        /// <summary>
        /// 生成实体类
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="json"></param>
        /// <returns></returns>
        public async Task<string> GetGenerationEntity(string Name, string json)
        {
            var r = await GetGenerationEntity("dawdwa","dawd");
            return r;
        }
    }
}
