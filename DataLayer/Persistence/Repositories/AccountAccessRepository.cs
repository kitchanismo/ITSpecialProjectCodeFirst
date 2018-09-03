using DataLayer.Core.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataLayer.Persistence.Repositories
{
    public class AccountAccessRepository : Repository<AccountAccess>
    {
        public AccountAccessRepository(AmigooDbContext context) : base(context)
        {
        }

        public AmigooDbContext AmigooDbContext => Context as AmigooDbContext;

        public IEnumerable<AccountAccess> GetByAccountId(int id)
        {
            return AmigooDbContext.AccountAccesses
                .Include(a => a.Module)
                .Where(a => a.AccountId == id)
                .ToList();
        }
    }
}
