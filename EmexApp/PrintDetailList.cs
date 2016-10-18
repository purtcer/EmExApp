using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace EmexApp
{
    class PrintDetailList
    {
        private Font printFont;
        List<InmConsumerDefault> MainInmConsumerList;
        StaticVariables.WholesalerElement MainWholesalerElement;
        int count = 0;
        public PrintDetailList(List<InmConsumerDefault> InmConsumerList, StaticVariables.WholesalerElement WholesalerElement)
        {
            MainInmConsumerList = InmConsumerList;
            MainWholesalerElement = WholesalerElement;
            Printing();
        }

        // The PrintPage event is raised for each page to be printed.
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            float lineHeigth = (float)((printFont.GetHeight(ev.Graphics)) * 1.5);

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height / lineHeigth;
            int countPage = 0;
            // Iterate over the file, printing each line.
            if (count == 0)
            {
                yPos = topMargin + (countPage * lineHeigth);
                ev.Graphics.DrawString(printClient(), printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                countPage++;
            }
            while (countPage < linesPerPage && count < MainInmConsumerList.Count)
            {
                InmConsumerDefault InmConsumerelements = MainInmConsumerList[count];
                //line = InmConsumerelements.DetailNum +  + InmConsumerelements.DetailNameRusUser;
                yPos = topMargin + (countPage * lineHeigth);
                ev.Graphics.DrawString(printLine(InmConsumerelements), printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
                countPage++;
            }

            // If more lines exist, print another page.
            if (count < MainInmConsumerList.Count)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        private string printLine(InmConsumerDefault InmConsumerelements)
        {
            StringBuilder line = new StringBuilder();
            line.Append("(" + InmConsumerelements.DetailNum + ") ");
            line.Append(InmConsumerelements.DetailNameRusUser);
            line.Append(" (" + InmConsumerelements.PotrebitelReference + ") - ");

            return line.ToString();
        }

        private string printClient()
        {
            StringBuilder line = new StringBuilder();
            line.Append("           " + MainWholesalerElement.UserId + " ");
            line.Append(MainWholesalerElement.UserFamily + " ");
            line.Append(MainWholesalerElement.UserLogo);

            return line.ToString();
        }

        // Print the file.
        public void Printing()
        {
            try
            {
                //streamToPrint = new StreamReader(filePath);
                try
                {
                    printFont = new Font("Arial", 12);
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                    // Print the document.
                    pd.Print();
                }
                finally
                {
                    //streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
