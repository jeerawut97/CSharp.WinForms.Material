namespace ExMaterial
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            homePage = new TabPage();
            aboutPage = new TabPage();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(homePage);
            materialTabControl1.Controls.Add(aboutPage);
            materialTabControl1.Depth = 0;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(-1, 67);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.Padding = new Point(10, 10);
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(802, 534);
            materialTabControl1.TabIndex = 0;
            // 
            // homePage
            // 
            homePage.ImageKey = "home.png";
            homePage.Location = new Point(4, 53);
            homePage.Name = "homePage";
            homePage.Padding = new Padding(3);
            homePage.Size = new Size(794, 477);
            homePage.TabIndex = 0;
            homePage.Text = "Home";
            homePage.UseVisualStyleBackColor = true;
            // 
            // aboutPage
            // 
            aboutPage.ImageKey = "info.png";
            aboutPage.Location = new Point(4, 53);
            aboutPage.Name = "aboutPage";
            aboutPage.Padding = new Padding(3);
            aboutPage.Size = new Size(794, 477);
            aboutPage.TabIndex = 1;
            aboutPage.Text = "About";
            aboutPage.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "home.png");
            imageList1.Images.SetKeyName(1, "info.png");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(materialTabControl1);
            DrawerTabControl = materialTabControl1;
            ForeColor = SystemColors.ControlText;
            Name = "MainForm";
            Text = "Material";
            materialTabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage homePage;
        private TabPage aboutPage;
        private ImageList imageList1;
    }
}
