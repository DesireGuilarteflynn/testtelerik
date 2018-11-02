using System;
using System.Runtime.Serialization;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Configuration;

namespace UITest1
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform, AppDataMode appDataMode = (AppDataMode)0)
        {
            // TODO: If the iOS or Android app being tested is included in the solution 
            // then open the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.
            //
            // The iOS project should have the Xamarin.TestCloud.Agent NuGet package
            // installed. To start the Test Cloud Agent the following code should be
            // added to the FinishedLaunching method of the AppDelegate:
            //
            //    #if ENABLE_TEST_CLOUD
            //    Xamarin.Calabash.Start();
            //    #endif
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .EnableLocalScreenshots()
                    // TODO: Update this path to point to your Android app and uncomment the
                    // code if the app is not included in the solution.
                    .ApkFile("../../../App1/App1.Android/bin/Debug/com.companyname.App1.apk")
                    .StartApp(appDataMode);
            }

            return ConfigureApp
                .iOS
                .EnableLocalScreenshots()
                //.DeviceIdentifier("A4EEC3C8-150E-4968-B9DD-F20534EB4599")
                //.InstalledApp("com.flynncompanies.coaching.dev")
                //.EnableLocalScreenshots()
                // TODO: Update this path to point to your iOS app and uncomment the
                // code if the app is not included in the solution.
                //.AppBundle ("../../../Coaching.iOS/bin/iPhoneSimulator/Debug/AuthTest.app")
                .StartApp(appDataMode);
        }
    }
}
