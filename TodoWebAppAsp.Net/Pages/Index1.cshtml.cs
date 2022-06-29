using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TodoWebAppAsp.Net.Pages
{
    public class Index1Model : PageModel
    {
        public string email { get; set; }
        public void OnGet(string _Email)
        {
            this.email = _Email;
            //email = Request.QueryString["email"];
        }
        
    }
}
