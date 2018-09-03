using DataLayer.Core.Model;
using DataLayer.Filters;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
//using Menu = ITSpecialProject.Core.Model.Menu;

namespace DataLayer.Persistence.Repositories
{
    public class MenuRepository : Repository<Menu>
    {
        public MenuRepository(AmigooDbContext context) : base(context)
        {
        }

        public AmigooDbContext AmigooDbContext => Context as AmigooDbContext;

        public IEnumerable<Menu> GetMenusByFilter(MenuFilter filter)
        {
            var menus = AmigooDbContext
                .Menus
                .Include(m => m.MenuCategory)
                .Where(m =>
                    m.Name.Contains(filter.MenuName) &&
                    m.CategoryId == filter.CategoryId &&
                    m.Availability == filter.Availability &&
                    m.Flag == filter.Flag)
                .OrderBy(m => m.Id)
                .Skip(filter.Skip)
                .Take(filter.Take)
                .ToList();

            return filter.MenuOrder.SetMenuOrder(menus);
        }

        public int Count(MenuFilter filter)
        {
            return AmigooDbContext
                .Menus
                .Count(m =>
                    m.Name.Contains(filter.MenuName) &&
                    m.CategoryId == filter.CategoryId &&
                    m.Availability == filter.Availability &&
                    m.Flag == filter.Flag);
        }

        public bool NameAlreadyUsed(string name)
        {
            return AmigooDbContext.Menus
                       .Count(m =>
                           m.Name == name) == 1;
        }

        public bool NameAlreadyUsed(int id, string name)
        {
            return AmigooDbContext.Menus
                       .Count(m =>
                           m.Id != id &&
                           m.Name == name) == 1;
        }

        public bool AcronymAlreadyUsed(string acronym)
        {
            return AmigooDbContext.Menus
                       .Count(m =>
                           m.Acronym == acronym) == 1;
        }

        public bool AcronymAlreadyUsed(int id, string acronym)
        {
            return AmigooDbContext.Menus
                       .Count(m =>
                           m.Id != id &&
                           m.Acronym == acronym) == 1;
        }
    }
}
