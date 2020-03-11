using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;

namespace BL
{
    public class pshow
    {
        public static void PopUp(Popup popup)
        {
            popup.IsOpen = true;
            DispatcherTimer zaman = new DispatcherTimer()
            {
                Interval = TimeSpan.FromSeconds(4)
            };
            zaman.Tick += delegate (object sender, EventArgs e)
            {
                ((DispatcherTimer)zaman).Stop();
                if (popup.IsOpen) popup.IsOpen = false;
            };
            zaman.Start();
        }
    }
    
}
