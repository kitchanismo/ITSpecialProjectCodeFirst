using DataLayer.Extensions;
using DataLayer.Core.Model;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Extensions
{
    public class MenuOrderByAscending : IMenuOrder
    {
        public IEnumerable<Menu> SetMenuOrder(IEnumerable<Menu> menus)
        {
            return menus.OrderBy(m => m.Name);
        }
    }

    public class MenuOrderByDescending : IMenuOrder
    {
        public IEnumerable<Menu> SetMenuOrder(IEnumerable<Menu> menus)
        {
            return menus.OrderByDescending(m => m.Name);
        }
    }

    public class MenuOrderByLowestPrice : IMenuOrder
    {
        public IEnumerable<Menu> SetMenuOrder(IEnumerable<Menu> menus)
        {
            return menus.OrderBy(m => m.Price);
        }
    }

    public class MenuOrderByHighestPrice : IMenuOrder
    {
        public IEnumerable<Menu> SetMenuOrder(IEnumerable<Menu> menus)
        {
            return menus.OrderByDescending(m => m.Price);
        }
    }
}
