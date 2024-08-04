namespace popup_cefsharp
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOk = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.grpBrowser = new System.Windows.Forms.GroupBox();
            this.panContainer = new System.Windows.Forms.Panel();
            this.grpPopup = new System.Windows.Forms.GroupBox();
            this.panContainerPopup = new System.Windows.Forms.Panel();
            this.grpBrowser.SuspendLayout();
            this.grpPopup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(882, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Go";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // txt_url
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(50, 6);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(826, 20);
            this.txtUrl.TabIndex = 8;
            // 
            // lbl_url
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 9);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(29, 13);
            this.lblUrl.TabIndex = 7;
            this.lblUrl.Text = "URL";
            // 
            // grp_browser
            // 
            this.grpBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBrowser.BackColor = System.Drawing.Color.White;
            this.grpBrowser.Controls.Add(this.panContainer);
            this.grpBrowser.Location = new System.Drawing.Point(3, 33);
            this.grpBrowser.Name = "grpBrowser";
            this.grpBrowser.Size = new System.Drawing.Size(963, 363);
            this.grpBrowser.TabIndex = 10;
            this.grpBrowser.TabStop = false;
            this.grpBrowser.Text = "Browser";
            // 
            // pan_container
            // 
            this.panContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panContainer.BackColor = System.Drawing.Color.Silver;
            this.panContainer.Location = new System.Drawing.Point(5, 19);
            this.panContainer.Name = "panContainer";
            this.panContainer.Size = new System.Drawing.Size(947, 338);
            this.panContainer.TabIndex = 0;
            // 
            // grp_popup
            // 
            this.grpPopup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPopup.BackColor = System.Drawing.Color.PowderBlue;
            this.grpPopup.Controls.Add(this.panContainerPopup);
            this.grpPopup.Location = new System.Drawing.Point(3, 404);
            this.grpPopup.Name = "grpPopup";
            this.grpPopup.Size = new System.Drawing.Size(963, 161);
            this.grpPopup.TabIndex = 11;
            this.grpPopup.TabStop = false;
            this.grpPopup.Text = "PopUp";
            // 
            // pan_container_popup
            // 
            this.panContainerPopup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panContainerPopup.BackColor = System.Drawing.Color.Silver;
            this.panContainerPopup.Location = new System.Drawing.Point(9, 19);
            this.panContainerPopup.Name = "panContainerPopup";
            this.panContainerPopup.Size = new System.Drawing.Size(944, 136);
            this.panContainerPopup.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 577);
            this.Controls.Add(this.grpPopup);
            this.Controls.Add(this.grpBrowser);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capture Event One Pop Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grpBrowser.ResumeLayout(false);
            this.grpPopup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.GroupBox grpBrowser;
        private System.Windows.Forms.Panel panContainer;
        private System.Windows.Forms.GroupBox grpPopup;
        private System.Windows.Forms.Panel panContainerPopup;
    }
}

