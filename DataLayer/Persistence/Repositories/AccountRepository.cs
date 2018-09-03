using DataLayer.Core.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataLayer.Persistence.Repositories
{
    public class AccountRepository : Repository<Account>
    {
        public AccountRepository(AmigooDbContext context) : base(context) { }

        public AmigooDbContext AmigooDbContext => Context as AmigooDbContext;

        public IEnumerable<string> GetAccountByQrCode()
        {
            return AmigooDbContext.Accounts
                .Select(a => (a.Id + string.Empty + a.CreationDate)
                .Replace("-", string.Empty))
                .ToList();
        }

        public (bool Exists, Account Account) Login(string userName, string userPass)
        {
            var account = AmigooDbContext
                .Accounts
                .SingleOrDefault(a => a.UserName == userName && a.UserPass == userPass);

            return account == null
                ? (false, null)
                : (true, account);
        }

        public IEnumerable<Account> GetAll((string searchKey, UserType userType, bool flag) filter, int skip, int take)
        {
            var account = AmigooDbContext
                .Accounts
                .Where(a =>
                    a.UserName.Contains(filter.searchKey) &&
                    a.UserLevel == filter.userType &&
                    a.Flag == filter.flag)
                .OrderBy(a => a.Id)
                .Skip(skip)
                .Take(take)
                .ToList();

            return account;
        }

        public int Count((string searchKey, UserType userType, bool flag) filter)
        {
            var account = AmigooDbContext
                .Accounts
                .Count(a =>
                    a.UserName.Contains(filter.searchKey) &&
                    a.UserLevel == filter.userType &&
                    a.Flag == filter.flag);

            return account;
        }

        public bool UserNameAlreadyUsed(string userName)
        {
            return AmigooDbContext.Accounts
                       .Count(a => a.UserName == userName) == 1;
        }

        public bool UserNameAlreadyUsed(string userName, int id)
        {
            return AmigooDbContext.Accounts
                       .Count(a => a.UserName == userName && a.Id != id) == 1;
        }
    }
}
