using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Repositories
{
    public interface ISupportOnlineRepository
    {
        //Truog hop co Phuong thuc can phai viet them
        //IEnumerable<...> GetByAlias(string alias);
    }

    public class SupportOnlineRepository : RepositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}