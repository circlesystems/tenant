using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace circleaccess.Pages
{
    // Define UserData class within the same file as IndexModel
    public class UserData
    {
        public string Customer { get; set; }
        public string Windows { get; set; }
        public int Saml { get; set; }
        public string Azure { get; set; }
        public string Admin { get; set; }

        public string SsoDomain { get; set; }

        public DateTime CreatedDate { get; set; }

    }

    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
         public List<UserData> Users { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // Initialize dummy data
            Users = new List<UserData>
            {
                new UserData {  Customer = "Customer1", Windows = "1", Saml = 1, Azure = "Azure1", Admin = "Admin1", CreatedDate = DateTime.Parse("Thu, 30 Nov 2023 17:04:20 GMT"), SsoDomain = "SSODomain1"},
                new UserData {  Customer = "Customer2", Windows = "1", Saml = 1, Azure = "Azure1", Admin = "Admin1", CreatedDate = DateTime.Parse("Thu, 30 Nov 2023 17:04:20 GMT"), SsoDomain = "SSODomain2"},
                new UserData {  Customer = "Customer3", Windows = "1", Saml = 1, Azure = "Azure1", Admin = "Admin1", CreatedDate = DateTime.Parse("Thu, 30 Nov 2023 17:04:20 GMT"), SsoDomain = "SSODomain3"},
                new UserData {  Customer = "Customer4", Windows = "1", Saml = 1, Azure = "Azure1", Admin = "Admin1", CreatedDate = DateTime.Parse("Thu, 30 Nov 2023 17:04:20 GMT"), SsoDomain = "SSODomain4"},
                new UserData {  Customer = "Customer5", Windows = "1", Saml = 1, Azure = "Azure1", Admin = "Admin1", CreatedDate = DateTime.Parse("Thu, 30 Nov 2023 17:04:20 GMT"), SsoDomain = "SSODomain5"},
                new UserData {  Customer = "Customer6", Windows = "1", Saml = 1, Azure = "Azure1", Admin = "Admin1", CreatedDate = DateTime.Parse("Thu, 30 Nov 2023 17:04:20 GMT"), SsoDomain = "SSODomain6"},
                new UserData {  Customer = "Customer7", Windows = "1", Saml = 1, Azure = "Azure1", Admin = "Admin1", CreatedDate = DateTime.Parse("Thu, 30 Nov 2023 17:04:20 GMT"), SsoDomain = "SSODomain7"},
                new UserData {  Customer = "Customer8", Windows = "1", Saml = 1, Azure = "Azure1", Admin = "Admin1", CreatedDate = DateTime.Parse("Thu, 30 Nov 2023 17:04:20 GMT"), SsoDomain = "SSODomain8"},
                new UserData {  Customer = "Customer9", Windows = "1", Saml = 1, Azure = "Azure1", Admin = "Admin1", CreatedDate = DateTime.Parse("Thu, 30 Nov 2023 17:04:20 GMT"), SsoDomain = "SSODomain9"},
                new UserData {  Customer = "Customer10", Windows = "1", Saml = 1, Azure = "Azure1", Admin = "Admin1", CreatedDate = DateTime.Parse("Thu, 30 Nov 2023 17:04:20 GMT"), SsoDomain = "SSODomain10"},
                new UserData {  Customer = "Customer12", Windows = "1", Saml = 1, Azure = "Azure1", Admin = "Admin1", CreatedDate = DateTime.Parse("Thu, 30 Nov 2023 17:04:20 GMT"), SsoDomain = "SSODomain11"},
                new UserData {  Customer = "Customer12", Windows = "1", Saml = 1, Azure = "Azure1", Admin = "Admin1", CreatedDate = DateTime.Parse("Thu, 30 Nov 2023 17:04:20 GMT"), SsoDomain = "SSODomain12"},
                new UserData {  Customer = "Customer13", Windows = "1", Saml = 1, Azure = "Azure1", Admin = "Admin1", CreatedDate = DateTime.Parse("Thu, 30 Nov 2023 17:04:20 GMT"), SsoDomain = "SSODomain13"},


            };
        }
    }
}
