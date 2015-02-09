using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.ApplicationTests
{
    [Category("when_i_add_product_to_new_cart")]
    public class when_i_add_product_to_new_cart : ECommerceManagerTestCase<string>
    {
        private string sku;
        private int quantity;
        
        public override void Given()
        {
            //i have a product sku
            sku = "Prod123";
            //i have a quantity
            quantity = 1;
        }

        public override void SetupMock()
        {
            throw new NotImplementedException();
        }

        public override string I_Call_Method()
        {
            throw new NotImplementedException();
        }
    }
}
