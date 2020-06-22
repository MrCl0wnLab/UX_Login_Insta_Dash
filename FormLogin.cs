using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace UX_Login_Insta
{
 
    public partial class FormLogin : Form
    {
        /* Gdi32.dll
        # exports Graphics Device Interface (GDI) functions that perform primitive 
        # drawing functions for output to video displays and printers. It is used, 
        # for example, in the XP version of Paint. Applications call GDI functions 
        # directly to perform low-level drawing (line, rectangle, ellipse), 
        # text output, font management, and similar functions
        # https://en.wikipedia.org/wiki/Microsoft_Windows_library_files#GDI32.DLL
        # https://en.wikipedia.org/wiki/Graphics_Device_Interface
        # https://docs.microsoft.com/en-us/windows/win32/gdi/windows-gdi
        # https://stackoverflow.com/questions/10674228/form-with-rounded-borders-in-c
        # https://www.youtube.com/watch?v=LE3y5a0G4JA */
        private bool mouseDown;
        private Point lastLocation;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public FormLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /* START movement FORM */
        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {

                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();

            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm(sender, e);
        }
        /* END movement FORM */

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin.ActiveForm.Hide();
            FormDash fmn = new FormDash();
            fmn.Show();
        }
       
    }
}
