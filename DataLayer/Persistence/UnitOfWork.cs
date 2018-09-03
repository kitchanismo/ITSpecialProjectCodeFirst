using DataLayer.Helpers;
using DataLayer.Core;
using DataLayer.Core.Model;
using DataLayer.Persistence.Repositories;
using System;

namespace DataLayer.Persistence
{
    public class UnitOfWork : IDisposable
    {
        private readonly AmigooDbContext _context;

        private UnitOfWork(AmigooDbContext context)
        {
            _context = context;

            #region Initialize Repositories

            Accounts = new AccountRepository(_context);

            AccountAccess = new AccountAccessRepository(_context);

            Menus = new MenuRepository(_context);

            MenuCategories = new MenuCategoryRepository(_context);

            #endregion
        }

        #region Repositories

        public AccountRepository Accounts { get; }

        public AccountAccessRepository AccountAccess { get; }

        public MenuRepository Menus { get; }

        public MenuCategoryRepository MenuCategories { get; }

        #endregion

        public bool TestConnection()
        {
            return DbHelper.CheckConnection(_context);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        #region Factory

        public static class Factory
        {
            public static UnitOfWork Instance()
            {
                return new UnitOfWork(new AmigooDbContext());
            }

            public static UnitOfWork Instance(AmigooDbContext context)
            {
                return new UnitOfWork(context);
            }

            public static UnitOfWork Instance(string connectionString)
            {
                return new UnitOfWork(new AmigooDbContext());
            }
        }

        #endregion
    }
}
