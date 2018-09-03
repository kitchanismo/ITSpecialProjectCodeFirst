using DataLayer.Extensions;

namespace DataLayer.Filters
{
    public class MenuFilter
    {
        public string MenuName { get; set; }

        public int CategoryId { get; set; }

        public bool Availability { get; set; }

        public bool Flag { get; set; }

        public IMenuOrder MenuOrder { get; set; }

        public int Skip { get; set; }

        public int Take { get; set; }
    }
}
