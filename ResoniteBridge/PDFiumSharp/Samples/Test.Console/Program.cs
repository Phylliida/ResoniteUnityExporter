using PDFiumSharp;
using System;
using System.IO;
using System.Reflection;

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			var exeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			using (var doc = new PdfDocument(exeDir + "/TestDoc.pdf", "password"))
			{
				Console.WriteLine($"Pages: {doc.Pages.Count}");
			}
		}
	}
}
