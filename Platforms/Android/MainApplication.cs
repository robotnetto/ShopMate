using Android.App;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Window = Android.Views.Window;

namespace ShopMate
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        
    }
}
