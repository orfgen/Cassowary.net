using NUnit.Framework;
using System;

namespace Cassowary.Tests
{
    [TestFixture]
    public class LayoutTestUnit
    {
        [Test]
        public void TestMethod()
        {
            LayoutTest._solver = new ClSimplexSolver();

            // initialize the needed variables
            LayoutTest.BuildVariables();

            // create the constraints
            try
            {
                LayoutTest.BuildConstraints();
            }
            catch (ExClRequiredFailure rf)
            {
                Console.Error.WriteLine(rf.StackTrace);
            }
            catch (ExClInternalError ie)
            {
                Console.Error.WriteLine(ie.StackTrace);
            }

            // solve it
            try
            {
                LayoutTest._solver.Solve();
            }
            catch (ExClInternalError ie)
            {
                Console.Error.WriteLine(ie.StackTrace);
            }

            // print out the values
            Console.WriteLine("Variables: ");
            LayoutTest.PrintVariables();

        }
    }
}
