using System;
using CoreGraphics;
using MultiColorProgressBar;
using UIKit;

namespace Sample
{
	public class MultiColorLoader
	{
		private UIView mainView;
		private BLMultiColorLoader loader = new BLMultiColorLoader();
		private UIView layerView;

		public MultiColorLoader(UIView view)
		{
			loader.ColorArray = new UIColor[] { UIColor.Green, UIColor.Red, UIColor.Yellow };
			loader.Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 2 - 15, UIScreen.MainScreen.Bounds.Height / 2 - 40, 30, 30);
			loader.LineWidth = 2.0f;
			this.mainView = view;
			layerView = new UIView(this.mainView.Frame);
			layerView.BackgroundColor = UIColor.White;
			layerView.Layer.Opacity = 0.6f;
		}

		public void Start()
		{
			this.mainView.AddSubviews(layerView, loader);
			loader.StartAnimation();
		}

		public void Dismiss()
		{
			loader.StopAnimation();
			layerView.RemoveFromSuperview();
			loader.RemoveFromSuperview();
		}
	}
}
