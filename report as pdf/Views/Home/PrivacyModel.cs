using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Add the MVC usings
//using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Web.Mvc;
//using System.Web.UI;


namespace report_as_pdf.Views.Home
{
    public class PrivacyModel: PageModel
    {

        public void OnGet()
        {

        }

        public ActionResult GetMessage()
        {
            string message = "Welcome";
            return new JsonResult { Data = message, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        protected void btnPassValues_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;
            //ScriptManager.RegisterStartupScript(this, GetType(), "AnyValue", "sumValues(" + a + "," + b + ");", true);
        }

    }
}
