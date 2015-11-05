// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace WebViews
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnSafari { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnSFSafariViewController { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnUIWebView { get; set; }

		[Action ("BtnSafari_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void BtnSafari_TouchUpInside (UIButton sender);

		[Action ("BtnSFSafariViewController_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void BtnSFSafariViewController_TouchUpInside (UIButton sender);

		[Action ("BtnUIWebView_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void BtnUIWebView_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnSafari != null) {
				btnSafari.Dispose ();
				btnSafari = null;
			}
			if (btnSFSafariViewController != null) {
				btnSFSafariViewController.Dispose ();
				btnSFSafariViewController = null;
			}
			if (btnUIWebView != null) {
				btnUIWebView.Dispose ();
				btnUIWebView = null;
			}
		}
	}
}
