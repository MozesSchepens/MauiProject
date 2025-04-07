using Android.App;
using Android.Runtime;

namespace MauiProject
{
    [Application]
    public class MainApplication : Android.App.Application
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            // Initialize your application here
        }
    }
}