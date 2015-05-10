using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace SearchPartyXamariniOs
{
	public partial class CameraViewController : UIViewController
	{
		public CameraViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void LukkView (MonoTouch.Foundation.NSObject sender) {
			this.NavigationController.PopViewControllerAnimated(true);
		}
		
		partial void StartKamera (MonoTouch.Foundation.NSObject sender) {
		}
	}
}

