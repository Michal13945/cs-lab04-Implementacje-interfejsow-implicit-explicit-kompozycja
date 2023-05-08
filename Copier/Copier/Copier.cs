﻿
using System.Reflection.Metadata;
using ver1;

namespace Zadanie1
{
    public class Copier : BaseDevice, IPrinter, IScanner
    {

        public int PrintCounter { get; private set; } = 0;
        public int ScanCounter { get; private set; } = 0;
        public int Counter => PrintCounter + ScanCounter;

        public void Print(in IDocument document)
        {
            if (GetState() == IDevice.State.off) return;
            PrintCounter++;

            Console.WriteLine($"{DateTime.Now} Print: {document.GetFileName()}");
        }

        public void Scan(out IDocument document, IDocument.FormatType formatType)
        {
            if (GetState() == IDevice.State.off)
            {
                document = null;
                return;
            }
            ScanCounter++;

            if (formatType == IDocument.FormatType.PDF)
            {
                document = new PDFDocument("xd.pdf");
                Console.WriteLine($"{DateTime.Now} Scan: {document.GetFileName()}");
            }
            else if (formatType == IDocument.FormatType.JPG)
            {
                document = new ImageDocument("xd.jpg");
                Console.WriteLine($"{DateTime.Now} Scan: {document.GetFileName()}");

            }else
            {
                document = new TextDocument("xd.txt");
                Console.WriteLine($"{DateTime.Now} Scan: {document.GetFileName()}");
            }
            
        }

        public void ScanAndPrint()
        {
            if (GetState() == IDevice.State.off) return;
            IDocument document;

            Scan(out document, IDocument.FormatType.JPG);
            Print(document);
        }
    }
}