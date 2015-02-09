using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Business
{
    public interface IEcommerceManager
    {
        string AddToBasket(string productSKU, int quantity);
    }
}
