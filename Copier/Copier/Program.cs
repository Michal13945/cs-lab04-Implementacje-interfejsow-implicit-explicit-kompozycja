﻿using ver1;
using Zadanie1;

var xerox = new Copier();
xerox.PowerOn();
IDocument doc1 = new PDFDocument("aaa.pdf");
xerox.Print(in doc1);

IDocument doc2;
xerox.Scan(out doc2, IDocument.FormatType.PDF);

xerox.ScanAndPrint();
System.Console.WriteLine(xerox.Counter);
System.Console.WriteLine(xerox.PrintCounter);
System.Console.WriteLine(xerox.ScanCounter);