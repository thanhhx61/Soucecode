using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KingFashionWeb.Models.Product;
using KingFashionWeb.Models.Category;
using KingFashionWeb.Models.Order;

namespace KingFashionWeb.Models
{
    public class ShopAll
    {
        public List<CategoryView> Categories { get; set; }
        public List<ProductView> Products { get; set; }
        public List<ViewOrder> viewOrders { get; set; }
    }
}
