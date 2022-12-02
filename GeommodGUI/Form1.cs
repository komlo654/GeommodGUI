using System.Runtime.InteropServices;

namespace GeommodGUI
{
    public partial class Form1 : Form
    {
        [DllImport("Surfaces.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Init();


        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}