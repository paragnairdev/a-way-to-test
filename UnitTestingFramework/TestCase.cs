using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingFramework
{
    [TestFixture]
    public abstract class TestCase<TClassUnderTest, TResult>
        where TClassUnderTest : class
        where TResult : class
    {
        protected TClassUnderTest ClassToTest;
        protected TResult Result;
        
        public abstract void Given();
        public abstract void SetupMock();
        public abstract TClassUnderTest InitializeClassUnderTest();
        public abstract TResult I_Call_Method();

        [Given]
        public virtual void Setup()
        {
            //setup input
            Given();

            //setup mock
            SetupMock();

            //initialize class to be tested
            this.ClassToTest = InitializeClassUnderTest();

            //call the method being tested
            this.Result = I_Call_Method();
        }
    }
}
