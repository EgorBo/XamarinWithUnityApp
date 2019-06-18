
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Widget;
using Com.Company.Product;

namespace HelloUnity
{
    [Activity(Label = "Hey!", 
        ScreenOrientation = ScreenOrientation.FullSensor, 
        LaunchMode = LaunchMode.SingleTask,
        HardwareAccelerated = true, 
        ConfigurationChanges = ConfigChanges.Mcc | 
                               ConfigChanges.Mnc | 
                               ConfigChanges.Locale |
                               ConfigChanges.UiMode |
                               ConfigChanges.Density |
                               ConfigChanges.Keyboard |
                               ConfigChanges.FontScale |
                               ConfigChanges.ScreenSize |
                               ConfigChanges.Navigation |
                               ConfigChanges.Touchscreen | 
                               ConfigChanges.Orientation | 
                               ConfigChanges.ScreenLayout | 
                               ConfigChanges.KeyboardHidden |
                               ConfigChanges.LayoutDirection |
                               ConfigChanges.SmallestScreenSize)]
    public class UnityActivity : OverrideUnityActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Button myButton = new Button(this);
            myButton.Text = "Xamarin button 1!";
            myButton.SetX(10);
            myButton.SetY(500);
            myButton.Click += (s, e) =>
            {
                UnitySendMessage("Cube", "ChangeColor", "yellow");
            };

            UnityFrameLayout.AddView(myButton, 400, 200);

            Button myButton2 = new Button(this);
            myButton2.Text = "Xamarin button 2!";
            myButton2.SetX(410);
            myButton2.SetY(500);
            myButton2.Click += (s, e) =>
            {
                UnitySendMessage("Cube", "ChangeColor", "red");
            };

            UnityFrameLayout.AddView(myButton2, 400, 200);
        }

        protected override void ShowMainActivity(string p)
        {
        }
    }
}