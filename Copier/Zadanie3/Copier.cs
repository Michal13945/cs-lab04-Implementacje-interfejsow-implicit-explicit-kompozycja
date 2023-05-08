
using ver1;

namespace Zadanie3
{
    public class Copier : BaseDevice
    {
        public int PrintCounter { get; private set; } = 0;
        public int ScanCounter { get; private set; } = 0;
        public int Counter => PrintCounter + ScanCounter;

        public Printer Printer { get; private set; }
        public Scaner Scanner { get; private set; }

        public void Scan(out IDocument document, IDocument.FormatType formatType)
        {
            
        }

        public void Print(in IDocument document)
        {

        }

        public void ScanAndPrint()
        {
           
        }
    }
}
