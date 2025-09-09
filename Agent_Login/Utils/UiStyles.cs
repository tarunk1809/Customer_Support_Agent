using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agent_Login.Utils
{
    public static class UiStyles
    {
        // Make the whole form rounded
        public static void ApplyRounded(Form form, int radius = 20)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.Padding = new Padding(0);

            form.Resize += (s, e) =>
            {
                if (form.Width > 0 && form.Height > 0)
                {
                    // Reduce 1px to avoid gaps on right/bottom edges
                    using (var path = RoundedRect(
                        new Rectangle(0, 0, form.Width - 1, form.Height - 1),
                        radius))
                    {
                        form.Region?.Dispose(); // dispose old region
                        form.Region = new Region(path);
                    }
                }
            };
        }


        // Make buttons rounded
        public static void MakeButtonRounded(Button btn, int radius = 15,
                                      Color? hoverColor = null,
                                      Color? normalColor = null)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            // Store original colors
            Color defaultBack = normalColor ?? btn.BackColor;
            Color hoverBack = hoverColor ?? Color.LightBlue;

            // Rounded corners applied on resize
            btn.Resize += (s, e) =>
            {
                if (btn.Width > 0 && btn.Height > 0)
                {
                    using (var path = RoundedRect(
                        new Rectangle(0, 0, btn.Width - 1, btn.Height - 1), radius))
                    {
                        btn.Region?.Dispose();
                        btn.Region = new Region(path);
                    }
                }
            };

            // Hover effect
            btn.MouseEnter += (s, e) => btn.BackColor = hoverBack;
            btn.MouseLeave += (s, e) => btn.BackColor = defaultBack;
        }



        // Gradient background for a panel
        public static void DrawGradient(Panel p, Color c1, Color c2)
        {
            p.Paint += (s, e) =>
            {
                using (var br = new LinearGradientBrush(p.ClientRectangle, c1, c2, 90f))
                {
                    e.Graphics.FillRectangle(br, p.ClientRectangle);
                }

            };
        }

        // Private helper for rounded shapes
        private static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
