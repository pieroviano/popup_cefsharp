using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace popup_cefsharp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        //variable browser
        ChromiumWebBrowser chrome, chrome_popup;

        private void InitializeBrowser()
        {
            try
            {
                CefSettings settings = new CefSettings();
                Cef.Initialize(settings);

                //main browser
                chrome = new ChromiumWebBrowser(this.txtUrl.Text.Trim());
                LifespanHandler life = new LifespanHandler();
                chrome.LifeSpanHandler = life;
                life.popup_request += life_popup_request;
                this.panContainer.Controls.Add(chrome);
                chrome.Dock = DockStyle.Fill;

                //popup browser
                chrome_popup = new ChromiumWebBrowser("");
                this.panContainerPopup.Controls.Add(chrome_popup);
                chrome_popup.Dock = DockStyle.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Error in initializing the browser. Error: {ex.Message}");
            }
        }

        private string GetRootDirectory()
        {
            // get directory where exe is executing
            string path = System.Environment.CurrentDirectory;

            //find index initiale paste bin
            int indice = path.IndexOf("bin", StringComparison.Ordinal);

            //get path root directory project
            path = path.Substring(0, indice);

            return path.Replace(@"\", @"/");
        }

        private void CarregarPopupNewBrowser(string url)
        {
            //open pop up in second browser
            chrome_popup.Load(url);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //close o object cef
            Cef.Shutdown();
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.txtUrl.Text = $@"file:///{GetRootDirectory()}page_test.html";

            //initialize the browser
            this.InitializeBrowser();
        }

        #region life_popup_request(string obj)
        private void life_popup_request(string obj)
        {
            //function for open pop up in a new browser
            this.CarregarPopupNewBrowser(obj);
        }
        #endregion

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                //this button will opening a new site

                //verify if the textbox is empty
                if (this.txtUrl.Text.Trim() == "")
                {
                    MessageBox.Show(@"The url must be filled");
                    return;
                }

                //open a new site
                chrome.Load(this.txtUrl.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Error in open the site. Error:{ex.Message}");
            }
        }
    }
}
