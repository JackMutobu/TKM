﻿using NoesisApp;

namespace TKM
{
    partial class App : Application
    {
        protected override Display CreateDisplay()
        {
            return new AndroidDisplay();
        }

        protected override RenderContext CreateRenderContext()
        {
            return new RenderContextEGL();
        }
    }

    [Android.App.Activity(Label = "TKM", MainLauncher = true, ConfigurationChanges =
        Android.Content.PM.ConfigChanges.ScreenSize |
        Android.Content.PM.ConfigChanges.Orientation |
        Android.Content.PM.ConfigChanges.KeyboardHidden,
        Theme = "@android:style/Theme.NoTitleBar.Fullscreen",
        LaunchMode = Android.Content.PM.LaunchMode.SingleInstance)]
    public class MainActivity : AndroidActivity
    {
        protected override void Main()
        {
            App app = new App();
            app.Uri = "/TKM;component/App.xaml";
            app.Run();
        }
    }
}