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
            pnService = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(panel3);
            panelTop.Controls.Add(panel2);
            panelTop.Controls.Add(panel1);
            panelTop.Controls.Add(pnService);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(5, 5, 5, 5);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1665, 190);
            panelTop.TabIndex = 0;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(panel4);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 190);
            panelLeft.Margin = new Padding(5, 5, 5, 5);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(307, 776);
            panelLeft.TabIndex = 1;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(307, 190);
            panelMain.Margin = new Padding(5, 5, 5, 5);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1358, 776);
            panelMain.TabIndex = 2;
            // 
            // pnService
            // 
            pnService.BackgroundImage = Properties.Resources.customer_satisfaction;
            pnService.BackgroundImageLayout = ImageLayout.Zoom;
            pnService.Location = new Point(139, 4);
            pnService.Name = "pnService";
            pnService.Size = new Size(256, 178);
            pnService.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.pet_food;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(555, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 178);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.selling;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(991, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 178);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.warehouse;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(1365, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(256, 178);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.logout;
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(23, 62);
            panel4.Name = "panel4";
            panel4.Size = new Size(256, 178);
            panel4.TabIndex = 1;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1665, 966);
            Controls.Add(panelMain);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 5, 5, 5);
            Name = "HomeForm";
            Text = "HomeForm";
            panelTop.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelLeft;
        private Panel panelMain;
        private Panel pnService;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
    }
}