using GlobalHost.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace GlobalHost.API
{
    class Loading
    {
        public static PictureBox Load(PictureBox pic)
        {
            pic.BackColor = Color.Transparent;
            pic.Image = Resources.load;
            pic.Width = Resources.load.Width;
            pic.Height = Resources.load.Height;
            pic.SizeMode = PictureBoxSizeMode.Normal;
            return pic;
        }
    }
}
