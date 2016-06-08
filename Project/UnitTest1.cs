using EPiServer.Framework;
using EPiServer.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Project
{
	[TestClass]
	public class UnitTest1
	{
		#region Methods

		[TestMethod]
		public void TestMethod1()
		{
			var log = LogManager.GetLogger(this.GetType());

			log.Information("Test");

			var initializationState = InitializationState.InitializeComplete;

			Assert.IsTrue(initializationState.GetType() == typeof(InitializationState));
		}

		#endregion
	}
}