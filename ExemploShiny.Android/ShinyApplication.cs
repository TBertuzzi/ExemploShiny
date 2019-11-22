using System;
using Android.App;
using Android.Runtime;

namespace ExemploShiny.Droid
{
    [Application]
    public class ShinyApplication : Shiny.ShinyAndroidApplication<Startup>
    {
        public ShinyApplication(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
        {

        }
    }
}
