using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.DataAccess
{
    public interface IProduct
    {
        decimal GetPrice(string sku);
    }
}
