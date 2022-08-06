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
        public static List<RefK12LeaTitleISupportService> RefK12LeaTitleISupportServiceList = new List<RefK12LeaTitleISupportService> =
        {
            new RefK12LeaTitleISupportService { Id=Guid.Parse("b1b9d1f3-f65d-41f4-9d98-00bc5bdad79c"), Code="Health, Dental and Eye Care is the type of support services provided to students in Title I programs.", Description="HealthDentalEyeCare", Definition="", SortOrder=0 },
            new RefK12LeaTitleISupportService { Id=Guid.Parse("e55b291e-c5bf-4728-8d64-c6f2ef7d3bf3"), Code="Supporting Guidance/Advocacy is the type of support services provided to students in Title I programs.", Description="GuidanceAdvocacy", Definition="", SortOrder=0 },
            new RefK12LeaTitleISupportService { Id=Guid.Parse("1977889f-0131-486f-a966-dc6cb8a46b2a"), Code="Any other type of support services provided to students in Title I programs.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefK12LeaTitleISupportService Pick List
         /// </summary>
        public static List<RefK12LeaTitleISupportService> RefK12LeaTitleISupportServicePickList = new List<RefK12LeaTitleISupportService> =
        {
            new RefK12LeaTitleISupportService { Id=Guid.Parse("b1b9d1f3-f65d-41f4-9d98-00bc5bdad79c"), Code="Health, Dental and Eye Care is the type of support services provided to students in Title I programs.", SortOrder=0 },
            new RefK12LeaTitleISupportService { Id=Guid.Parse("e55b291e-c5bf-4728-8d64-c6f2ef7d3bf3"), Code="Supporting Guidance/Advocacy is the type of support services provided to students in Title I programs.", SortOrder=0 },
            new RefK12LeaTitleISupportService { Id=Guid.Parse("1977889f-0131-486f-a966-dc6cb8a46b2a"), Code="Any other type of support services provided to students in Title I programs.", SortOrder=0 },
       };
   }
}
