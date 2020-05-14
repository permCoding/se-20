using System;
using System.Windows.Forms;

namespace WFA_mm
{
    public class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMM());
        }
    }

    public partial class FormMM : Form
    {
        public FormMM()
        {
            InitializeComponent();
        }

        private void FormMM_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X.ToString() + ':' + e.Y.ToString();
			// this.Text = String.Format("X = {0}; Y = {1}", e.X, e.Y);
        }
    }
	
	public partial class FormMM
    {
        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(800, 450);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMM_MouseMove);
        }
    }
}
