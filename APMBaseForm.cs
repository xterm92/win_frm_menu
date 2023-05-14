using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using APMPublicLib.Common;

public partial class APMBaseForm : Form
{
        public APMBaseForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            SetRegin();
        }

        #region WndProc
        protected override void WndProc(ref Message m)
        {

            switch (m.Msg)
            {
                case APMApiPublic.WM_ACTIVATEAPP:
                    if (m.WParam.ToInt32() == 1)
                    {
                        APMApiPublic.SystemParametersInfo(APMApiPublic.SPI_SETDRAGFULLWINDOWS, 0, null, APMApiPublic.SPIF_SENDWININICHANGE);
                    }
                    else
                    {
                        APMApiPublic.SystemParametersInfo(APMApiPublic.SPI_SETDRAGFULLWINDOWS, 1, null, APMApiPublic.SPIF_SENDWININICHANGE);
                    }
                    break;
                case APMApiPublic.WM_NCACTIVATE:
                    IntPtr hdc1 = APMApiPublic.GetWindowDC(m.HWnd);
                    Graphics g1 = Graphics.FromHdc(hdc1);
                    g1.FillRectangle(Brushes.Black, new Rectangle(5, 0, 2, Height));
                    g1.FillRectangle(Brushes.Black, new Rectangle(0, 5, Width, 2));
                    g1.FillRectangle(Brushes.Black, new Rectangle(Width - 7, 5, 4, Height));
                    g1.FillRectangle(Brushes.Black, new Rectangle(5, Height - 7, Width, 4));

                    g1.Flush();
                    APMApiPublic.ReleaseDC(this.Handle, hdc1);
                    g1.Dispose();
                    break;
                case APMApiPublic.WM_NCPAINT:
                    IntPtr hdc = APMApiPublic.GetWindowDC(m.HWnd);
                    Graphics g = Graphics.FromHdc(hdc);
                    g.FillRectangle(Brushes.Black, new Rectangle(5, 0, 2, Height));
                    g.FillRectangle(Brushes.Black, new Rectangle(0, 5, Width, 2));
                    g.FillRectangle(Brushes.Black, new Rectangle(Width - 8, 5, 4, Height));
                    g.FillRectangle(Brushes.Black, new Rectangle(5, Height - 8, Width, 4));


                    g.Flush();
                    APMApiPublic.ReleaseDC(this.Handle, hdc);
                    g.Dispose();
                    break;
            }
            base.WndProc(ref m);
        }
        #endregion   

        private void APMBaseForm_Resize(object sender, EventArgs e)
        {
            SetRegin();
        }
        public void SetRegin()
        {
            try
            {
                Region = System.Drawing.Region.FromHrgn(APMApiPublic.CreateRoundRectRgn(5, 5, Width - 4, Height - 4, 0, 0));
            }
            catch (ArgumentException exp)
            {
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
}
