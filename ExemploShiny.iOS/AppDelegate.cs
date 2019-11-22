using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace ExemploShiny.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }

        public override void PerformFetch(UIApplication application, Action<UIBackgroundFetchResult> completionHandler)
                 => Shiny.Jobs.JobManager.OnBackgroundFetch(completionHandler);
    }
}
