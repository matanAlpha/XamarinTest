using System;

using UIKit;

namespace XamarinTest.iOS
{
	public partial class MyViewController : UIViewController
	{
		public MyViewController() : base("MyViewController", null)
		{
		}

		public MyViewController(IntPtr p) : base(p)
		{
		}

		public string labelTPass = "";

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			this.yafeLabel.Text = labelTPass;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

