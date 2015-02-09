using Acme.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Business
{
    public class ECommerceManager : IEcommerceManager
    {
        private IProduct productDataService;
        private IInventory inventoryDataService;
        private IEcommerce ecommerceDataService;

        public ECommerceManager(IProduct productDataService, IInventory inventoryDataService, IEcommerce ecommerceDataService)
        {
            this.productDataService = productDataService;
            this.inventoryDataService = inventoryDataService;
            this.ecommerceDataService = ecommerceDataService;
        }

        public string AddToBasket(string productSKU, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
