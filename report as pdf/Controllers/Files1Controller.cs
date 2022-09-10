using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using GroupDocs.Viewer;
using GroupDocs.Conversion;
using GroupDocs.Viewer.Options;

namespace report_as_pdf.Controllers
{
    public class Files1Controller : Controller
    {

        IHostingEnvironment _hostingEnvironment = null;
        
        public Files1Controller(IHostingEnvironment hostingEnvironment) 
        {
        
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public IActionResult Index(string fileName = "")
        {
            FileClass fileObj = new FileClass();
            fileObj.Name = fileName;
            
            
            string path =$"{_hostingEnvironment.WebRootPath}\\files\\";
            int nId = 1;

            foreach(string pdfpath in Directory.EnumerateFiles(path , "*.pdf"))
            {
                fileObj.Files.Add(new FileClass()
                {
                    FileId=nId++,
                    Name=Path.GetFileName(pdfpath),
                    Path=pdfpath
                });
            }
            return View(fileObj);
        }


        [HttpPost]
        public IActionResult Index(IFormFile file,[FromServices] IHostingEnvironment hostingEnvironment)
        {
            string fileName = $"{hostingEnvironment.WebRootPath}\\files\\{file.FileName}";
            using(FileStream fileStream = System.IO.File.Create(fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            return View();
        }

        public IActionResult PdfViewerNewTab(string fileName)
        {
            string path= _hostingEnvironment.WebRootPath + "\\files\\" + fileName;




            return File(System.IO.File.ReadAllBytes(path),"application/pdf");
        }

        public IActionResult btnDownload_Click(string hdata)
		{
            //HtmlElement tableElem = WebBrowser.Document.GetElementById(tableID);


            //HtmlElement el = webBrowser1.Document.GetElementById("content").GetElementsByTagName("a")[0];
            //String anchorText = el.InnerText; // will contain "K"
            //String url = el.GetAttribute("href"); // will contain "test"

            string nn = "tst.html";
			string apath = _hostingEnvironment.WebRootPath + "\\" + nn;
            string opath = _hostingEnvironment.WebRootPath + "\\files\\" + "output123321.pdf";


			return File(System.IO.File.ReadAllBytes(opath), "application/pdf");



            string araer = "asdasdad";
		}

    }
}
