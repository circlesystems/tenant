using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace circleaccess.Pages
{
    public class EmailsModel : PageModel
    {
        public List<EmailData> EmailList { get; set; }

        public void OnGet()
        {
            // Populate dummy data
            EmailList = new List<EmailData>
            {
                new EmailData { UserName = "John Doe", Email = "john@example.com", CircleAccess = true, CircleData =false, CirclePassport = true },
                new EmailData { UserName = "Jane Smith", Email = "jane@example.com", CircleAccess = false, CircleData = true, CirclePassport = false },
                // Add more dummy data as needed
            };
        }
    }

    public class EmailData
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool CircleAccess { get; set; }
        public bool CircleData { get; set; }
        public bool CirclePassport { get; set; }
    }
 

}


