namespace foodPetManager
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            panelTop = new Panel();
            panelLeft = new Panel();
            panelMain = new Panel();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(973, 119);
            panelTop.TabIndex = 0;
            // 
            // panelLeft
            // 
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 119);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(189, 446);
            panelLeft.TabIndex = 1;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(189, 119);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(784, 446);
            panelMain.TabIndex = 2;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 565);
            Controls.Add(panelMain);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomeForm";
            Text = "HomeForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelLeft;
        private Panel panelMain;
    }
}