using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrivateObjectExample.Tests
{
    [TestClass]
    public class WorkRepositoryTests
    {
        [TestMethod]
        public void ConnectionTrueMustReturnTrue()
        {
            var workRepository = new WorkRepository();
        }
    }
}


