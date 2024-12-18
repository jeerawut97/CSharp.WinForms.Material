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
        }
    }
}
