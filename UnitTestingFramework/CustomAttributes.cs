using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingFramework
{
    public class GivenAttribute : TestFixtureSetUpAttribute { }

    public class WhenAttribute : GivenAttribute { }

    public class ThenAttribute : TestAttribute { }
}
