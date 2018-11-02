using System;
using System.IO;
using System.Linq;
using Android.OS;
using Telerik.JustMock;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);

            var bundle = Telerik.JustMock.Mock.Create<Bundle>();
            Telerik.JustMock.Mock.Arrange(() => bundle.ContainsKey("key")).Returns(true);

            app.Invoke("MockSplashScreen", bundle);
        }

        [Test]
        public void MockTest()
        {
            app.Screenshot("First Screem");
        }
    }
}
