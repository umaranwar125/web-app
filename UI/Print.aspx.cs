using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.Web.UI.WebControls;
using BOL;
using BLL;

namespace UI
{
    public partial class Print : System.Web.UI.Page
    {
        public List<MissingPeoplePageObjects> displayMissingPeopleData;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Print-Missing-People-ID"] == null)
                Response.Redirect("index");
            else
            {
                DisplayMissingPeople();
            }
        }

        protected void PrintBtn_Click(object sender, EventArgs e)
        {
            //server folder path which is stored your PDF documents
            string path = Server.MapPath("Image");
            string imagepath = Server.MapPath("Image");
            string filename = path + "/Doc1.pdf";


            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=OrderInvoice.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            Panel1.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imagepath + "/" + myImg.Src);
            pdfDoc.Open();
            pdfDoc.Add(img);
            htmlparser.Parse(sr);
            pdfDoc.Close();
            Response.Write(pdfDoc);
            Response.End();
        }

        private void DisplayMissingPeople()
        {
            DefaultBussiness ob = new DefaultBussiness();
            displayMissingPeopleData = ob.SelectMissingPeoplePostForPrint(Convert.ToInt32(Request.QueryString["Print-Missing-People-ID"]));
        }
    }
}