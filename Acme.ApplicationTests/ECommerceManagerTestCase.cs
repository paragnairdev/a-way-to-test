using Acme.Business;
using Acme.DataAccess;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingFramework;

namespace Acme.ApplicationTests
{
    public abstract class ECommerceManagerTestCase<TResult> : TestCase<ECommerceManager, TResult>
        where TResult : class
    {
        protected Mock<IProduct> productDataService = new Mock<IProduct>();
        protected Mock<IInventory> inventoryDataService = new Mock<IInventory>();
        protected Mock<IEcommerce> ecommerceDataService = new Mock<IEcommerce>();

        public override ECommerceManager InitializeClassUnderTest()
        {
            return new ECommerceManager(productDataService.Object, inventoryDataService.Object, ecommerceDataService.Object);
        }
    }
}
