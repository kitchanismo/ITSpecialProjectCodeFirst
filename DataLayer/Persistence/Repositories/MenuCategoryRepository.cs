using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Core.Model;

namespace DataLayer.Persistence.Repositories
{
    public class MenuCategoryRepository : Repository<MenuCategory>
    {
        public MenuCategoryRepository(AmigooDbContext context) : base(context) { }

        public AmigooDbContext AmigooDbContext => Context as AmigooDbContext;
    }
}
