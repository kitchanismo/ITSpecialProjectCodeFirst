using DataLayer.Core.Model;
using System.Collections.Generic;

namespace DataLayer.Extensions
{
    public interface IMenuOrder
    {
        IEnumerable<Menu> SetMenuOrder(IEnumerable<Menu> menus);
    }
}
