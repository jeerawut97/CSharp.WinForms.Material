using CSharp.WinForms.Material;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ExMaterial
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.MinimumSize = new Size(800, 600);
            this.MaximumSize = new Size(800, 600);

            HomeControl homeControl = new HomeControl();
            homeControl.Dock = DockStyle.Fill;
            homePage.Controls.Add(homeControl);

            AboutControl aboutControl = new AboutControl();
            aboutControl.Dock = DockStyle.Fill;
            aboutPage.Controls.Add(aboutControl);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.LightBlue900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
    }
}
