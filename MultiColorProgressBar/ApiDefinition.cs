using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace MultiColorProgressBar
{
	[BaseType(typeof(UIView))]
	interface BLMultiColorLoader
	{
		// @property (nonatomic, strong) NSArray * colorArray;
		[Export("colorArray", ArgumentSemantic.Strong)]
		NSObject[] ColorArray { get; set; }

		// @property (nonatomic) CGFloat lineWidth;
		[Export("lineWidth")]
		nfloat LineWidth { get; set; }

		// -(void)startAnimation;
		[Export("startAnimation")]
		void StartAnimation();

		// -(void)stopAnimation;
		[Export("stopAnimation")]
		void StopAnimation();

		// -(void)stopAnimationAfter:(NSTimeInterval)timeInterval;
		[Export("stopAnimationAfter:")]
		void StopAnimationAfter(double timeInterval);

		// -(BOOL)isAnimating;
		[Export("isAnimating")]
		bool IsAnimating { get; }
	}
}
