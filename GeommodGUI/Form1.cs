using System.Runtime.InteropServices;

namespace GeommodGUI
{
    public partial class Form1 : Form
    {
        bool show_controllpoints = true;
        bool show_grid = true;
        int param_X, param_Z;


        [DllImport("Surfaces.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Init();

        [DllImport("Surfaces.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void HandleControllPointsShow(bool value);

        [DllImport("Surfaces.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void HandleGridShow(bool value);

        [DllImport("Surfaces.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ControllPointsToDefault();

        [DllImport("Surfaces.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void HandleNumberOfControllPointsChange(int param_X, int param_Z);

        [DllImport("Surfaces.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void HandleSurfaceIdChange(int surface_id);

        [DllImport("Surfaces.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void HandleDensityChange(int density);


        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void coltrollPointsToDefaultButton_Click(object sender, EventArgs e)
        {
            ControllPointsToDefault();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            param_X = Convert.ToInt32(numericUpDown1.Value);
            HandleNumberOfControllPointsChange(param_X, param_Z);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            param_Z = Convert.ToInt32(numericUpDown2.Value);
            HandleNumberOfControllPointsChange(param_X, param_Z);
        }

        private void controllPointsShowHandlerButton_Click(object sender, EventArgs e)
        {
            if (show_controllpoints)
            {
                controllPointsShowHandlerButton.Text = "Kontrollpontok: BE";
                show_controllpoints = false;
            } else
            {
                controllPointsShowHandlerButton.Text = "Kontrollpontok: KI";
                show_controllpoints = true;
            }

            HandleControllPointsShow(show_controllpoints);
        }

        private void gridShowHandlerButton_Click(object sender, EventArgs e)
        {
            if (show_grid)
            {
                gridShowHandlerButton.Text = "Kontrollpontháló: BE";
                show_grid = false;
            }
            else
            {
                gridShowHandlerButton.Text = "Kontrollpontháló: KI";
                show_grid = true;
            }

            HandleGridShow(show_grid);
        }

        private void bezierRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bezierRadioButton.Checked)
            {
                HandleSurfaceIdChange(1);
            }
        }

        private void bSplineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bSplineRadioButton.Checked)
            {
                HandleSurfaceIdChange(2);
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            HandleDensityChange(Convert.ToInt32(numericUpDown3.Value));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bezierRadioButton.Checked = true;
            param_X = Convert.ToInt32(numericUpDown1.Value);
            param_Z = Convert.ToInt32(numericUpDown2.Value);
        }
    }
}