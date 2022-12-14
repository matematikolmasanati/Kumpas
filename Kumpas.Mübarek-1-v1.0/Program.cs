using System.Media;
using System.Windows.Forms;

namespace Kumpas.Mübarek_1_v10
{
    static class Program
    {
        static void Main()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "fon.wav";
            player.PlayLooping();
            Application.Run();
        }
    }
}
