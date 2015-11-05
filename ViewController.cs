using System;

using UIKit;
using Foundation;
using SafariServices;

namespace WebViews
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }


        NSUrl url = new NSUrl("http://xamarin.com/");

        partial void BtnSafari_TouchUpInside(UIButton sender)
        {
            UIApplication.SharedApplication.OpenUrl(url);
        }

        partial void BtnUIWebView_TouchUpInside(UIButton sender)
        {
            var webview = new UIWebView(this.View.Bounds);
            webview.LoadRequest(new NSUrlRequest(url));
            View.AddSubview(webview);
        }

        partial void BtnSFSafariViewController_TouchUpInside(UIButton sender)
        {
            var sfViewController = new SFSafariViewController(url);
            PresentViewControllerAsync(sfViewController, true);
        }
    }
}

