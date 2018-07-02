using System.Drawing;
using System.Windows.Forms;

public class NewProgressBar : ProgressBar
{
    public NewProgressBar()
    {
        this.SetStyle(ControlStyles.UserPaint, true);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Rectangle rec = e.ClipRectangle;

        rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;

        if (ProgressBarRenderer.IsSupported)
            ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);


        //clear graphics
        e.Graphics.Clear(Color.Black);

        rec.Height = rec.Height - 4;

        //draw progressbar
        e.Graphics.FillRectangle(Brushes.Green, 2, 2, rec.Width, rec.Height);
    }
}