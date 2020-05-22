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

    public class FormMM : Form
    {
        public FormMM()
        {
            this.ClientSize = new System.Drawing.Size(800, 450);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMM_MouseMove);
        }

        private void FormMM_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X.ToString() + ':' + e.Y.ToString();
        }
    }
}
