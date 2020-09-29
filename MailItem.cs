using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clemakro.MailCheckClient
{
    public class MailItem
    {
        public enum StatusType { Error, Sent, Received, TimedOut, Cancelled };

        public StatusType Status { set; get; }
        public DateTime Timestamp { set; get; }
        public long Ticks { set; get; }
        public String ToAddress { set; get; }
        public DateTime TimeoutTimestamp { set; get; }
        public ListViewItem viewItem { set; get; }

    }
}
