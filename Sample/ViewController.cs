using System;
using System.Threading;
using System.Threading.Tasks;
using CoreGraphics;
using Foundation;
using MultiColorProgressBar;
using ObjCRuntime;
using UIKit;

namespace Sample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{

		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			MultiColorLoader loader = new MultiColorLoader(this.View);
			BtnClickMe.TouchUpInside += (sender, e) => {
				loader.Start();
				Task.Factory.StartNew(() => {
					Thread.Sleep(10000);
					this.InvokeOnMainThread(() => {
						loader.Dismiss();
					});
				});
			};
		}
	}
}
