using log4net.Appender;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clemakro.MailCheckClient
{
    public class RichTextBoxAppender : AppenderSkeleton
    {
        public RichTextBox RichTextBox { get; set; }

        protected override void Append(LoggingEvent loggingEvent)
        {
            System.Drawing.Color selectionColor;

            switch (loggingEvent.Level.DisplayName.ToUpper())
            {
                case "FATAL":
                    selectionColor = System.Drawing.Color.DarkRed;
                    break;

                case "ERROR":
                    selectionColor = System.Drawing.Color.Red;
                    break;

                case "WARN":
                    selectionColor = System.Drawing.Color.DarkOrange;
                    break;

                case "INFO":
                    selectionColor = System.Drawing.Color.Teal;
                    break;

                case "DEBUG":
                    selectionColor = System.Drawing.Color.Green;
                    break;

                default:
                    selectionColor = System.Drawing.Color.Black;
                    break;
            }


            Action operation = () => {
                this.RichTextBox.SelectionColor = selectionColor;
                this.RichTextBox.AppendText(RenderLoggingEvent(loggingEvent));
            };
            this.RichTextBox.Invoke(operation);
        }
    }
}
