using Android.App;
using Android.Content.PM;
using Android.OS;
using AndroidX.Core.View;

namespace Magic_Counter;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density, ScreenOrientation = ScreenOrientation.Landscape)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        WindowCompat.SetDecorFitsSystemWindows(this.Window, false);
        WindowInsetsControllerCompat windowInsetsController = new WindowInsetsControllerCompat(this.Window, this.Window.DecorView);
        // Hide system bars
        windowInsetsController.Hide(WindowInsetsCompat.Type.SystemBars());
        windowInsetsController.SystemBarsBehavior = WindowInsetsControllerCompat.BehaviorShowTransientBarsBySwipe;
        DeviceDisplay.Current.KeepScreenOn = true;
    }
}
