//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAltRouteToCertificationOrLicensureList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAltRouteToCertificationOrLicensure Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAltRouteToCertificationOrLicensure"> List
         /// </summary>
        public static List<RefAltRouteToCertificationOrLicensure> RefAltRouteToCertificationOrLicensureList = new List<RefAltRouteToCertificationOrLicensure> =
        {
            new RefAltRouteToCertificationOrLicensure { Id=Guid.Parse("3c6819c1-17f3-4d71-8fb4-e4fd9cf0bdf3"), Code="", Description="Yes", Definition="", SortOrder=0 },
            new RefAltRouteToCertificationOrLicensure { Id=Guid.Parse("733300ef-00a9-42c8-85a6-74e924227a5e"), Code="", Description="No", Definition="", SortOrder=0 },
            new RefAltRouteToCertificationOrLicensure { Id=Guid.Parse("a207291a-1c41-40b4-bc7f-21f8cad92a78"), Code="", Description="NA", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAltRouteToCertificationOrLicensure Pick List
         /// </summary>
        public static List<RefAltRouteToCertificationOrLicensure> RefAltRouteToCertificationOrLicensurePickList = new List<RefAltRouteToCertificationOrLicensure> =
        {
            new RefAltRouteToCertificationOrLicensure { Id=Guid.Parse("3c6819c1-17f3-4d71-8fb4-e4fd9cf0bdf3"), Code="", SortOrder=0 },
            new RefAltRouteToCertificationOrLicensure { Id=Guid.Parse("733300ef-00a9-42c8-85a6-74e924227a5e"), Code="", SortOrder=0 },
            new RefAltRouteToCertificationOrLicensure { Id=Guid.Parse("a207291a-1c41-40b4-bc7f-21f8cad92a78"), Code="", SortOrder=0 },
       };
   }
}
