using System.Windows.Forms;

namespace MayinTarlasi
{
    public class MSDButton : Button
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool MayinMi { get; set; } = false;
        public bool AcildiMi { get; set; } = false;
    }
}
