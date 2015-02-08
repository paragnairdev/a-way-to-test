using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.DataAccess
{
    public interface IInventory
    {
        bool IsProductAvailable(string sku, int quantity);
    }
}
