using System;

using Android.App;
using Android.OS;
using Android.Runtime;

namespace Mono.Samples.Button
{
	public class ButtonActivity : Activity
	{
		int count = 0;

		public ButtonActivity (IntPtr handle) : base (handle)
		{
		}

		protected override void OnCreate (Bundle bundle)
		{
#if MONODROID_TIMING
			Logger.Log(LogLevel.Info, "MonoDroid-Timing", "ButtonActivity.OnCreate: time: " + (DateTime.Now - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif
			base.OnCreate (bundle);

			// Create your application here
			Android.Widget.Button button = new Android.Widget.Button (this);

			button.Text = string.Format ("{0} clicks!!", count);
			button.Click += delegate { button.Text = string.Format ("{0} clicks!!", ++count); };

			SetContentView (button);
		}
	}
}

