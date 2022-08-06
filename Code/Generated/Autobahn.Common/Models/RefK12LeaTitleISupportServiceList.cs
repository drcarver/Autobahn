//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefK12LeaTitleISupportServiceList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefK12LeaTitleISupportService Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefK12LeaTitleISupportService"> List
         /// </summary>
        public static List<RefK12LeaTitleISupportService> RefK12LeaTitleISupportServiceList = new List<RefK12LeaTitleISupportService>
        {
            new RefK12LeaTitleISupportService { Id=Guid.Parse("f3e5443f-ad5e-43d0-9078-9a0af5748064"), Code="HealthDentalEyeCare", Description="Health, Dental and Eye Care", Definition="Health, Dental and Eye Care is the type of support services provided to students in Title I programs.", SortOrder=Convert.ToDecimal("1.00") },
            new RefK12LeaTitleISupportService { Id=Guid.Parse("1e961676-a8d0-419b-a0fd-6caabf718933"), Code="GuidanceAdvocacy", Description="Supporting Guidance/Advocacy", Definition="Supporting Guidance/Advocacy is the type of support services provided to students in Title I programs.", SortOrder=Convert.ToDecimal("2.00") },
            new RefK12LeaTitleISupportService { Id=Guid.Parse("bcd5ee4e-cb08-4365-b133-c6f90fa64cef"), Code="Other", Description="Other", Definition="Any other type of support services provided to students in Title I programs.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefK12LeaTitleISupportService Pick List
         /// </summary>
        public static List<RefK12LeaTitleISupportService> RefK12LeaTitleISupportServicePickList = new List<RefK12LeaTitleISupportService>
        {
            new RefK12LeaTitleISupportService { Id=Guid.Parse("f3e5443f-ad5e-43d0-9078-9a0af5748064"), Code="HealthDentalEyeCare", Description="Health, Dental and Eye Care", SortOrder=Convert.ToDecimal("1.00") },
            new RefK12LeaTitleISupportService { Id=Guid.Parse("1e961676-a8d0-419b-a0fd-6caabf718933"), Code="GuidanceAdvocacy", Description="Supporting Guidance/Advocacy", SortOrder=Convert.ToDecimal("2.00") },
            new RefK12LeaTitleISupportService { Id=Guid.Parse("bcd5ee4e-cb08-4365-b133-c6f90fa64cef"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
