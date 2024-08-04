using System;
using CefSharp;

namespace popup_cefsharp
{
    public class LifespanHandler: ILifeSpanHandler
    {
        //event that receive url popup
        public event Action<string> popup_request;

        bool ILifeSpanHandler.OnBeforePopup(IWebBrowser browserControl, IBrowser browser, IFrame frame, string targetUrl, string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
        {
            //get url popup
            this.popup_request?.Invoke(targetUrl);

            //stop open popup
            newBrowser = null;
            return true;
        }

        /// <summary>
        /// </summary>
        /// <param name="browserControl">The <see cref="IWebBrowser"/> control that is realted to the window is closing.</param>
        /// <param name="browser">The browser instance - check if IsDisposed as it's possible when the browser is disposing</param>
        /// <returns>For default behaviour return false</returns>
        bool ILifeSpanHandler.DoClose(IWebBrowser browserControl, IBrowser browser)
        { return false; }

        /// <summary>
        /// Called before a CefBrowser window (either the main browser for <see cref="IWebBrowser"/>, 
        /// or one of its children)
        /// </summary>
        /// <param name="browserControl">The <see cref="IWebBrowser"/> control that is realted to the window is closing.</param>
        /// <param name="browser">The browser instance</param>
        void ILifeSpanHandler.OnBeforeClose(IWebBrowser browserControl, IBrowser browser){}

        /// <summary>
        /// Called after a new browser is created.
        /// </summary>
        /// <param name="browserControl">The <see cref="IWebBrowser"/> control that is realted to the window is closing.</param>
        /// <param name="browser">The browser instance</param>
        void ILifeSpanHandler.OnAfterCreated(IWebBrowser browserControl, IBrowser browser) {}
    }
}
