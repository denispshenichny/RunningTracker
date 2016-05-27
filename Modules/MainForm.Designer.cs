namespace RunningTracker {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.baseMapBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // baseMapBtn
            // 
            this.baseMapBtn.Location = new System.Drawing.Point(522, 12);
            this.baseMapBtn.Name = "baseMapBtn";
            this.baseMapBtn.Size = new System.Drawing.Size(87, 23);
            this.baseMapBtn.TabIndex = 0;
            this.baseMapBtn.Text = "Базовая карта";
            this.baseMapBtn.Click += new System.EventHandler(this.baseMapBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 531);
            this.Controls.Add(this.baseMapBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton baseMapBtn;

    }
}

