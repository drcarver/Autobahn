//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDActivityCreditTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPDActivityCreditType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPDActivityCreditType"> List
         /// </summary>
        public static List<RefPDActivityCreditType> RefPDActivityCreditTypeList = new List<RefPDActivityCreditType> =
        {
            new RefPDActivityCreditType { Id=Guid.Parse("68e4e064-1a2d-4299-9fcf-c5be6428ac55"), Code="Hours is the type of professional development credit awarded.", Description="Hours", Definition="", SortOrder=0 },
            new RefPDActivityCreditType { Id=Guid.Parse("7b147b86-afe1-46ec-9edc-53f150b5cdd4"), Code="Continuing Education Units is the type of professional development credit awarded.", Description="CEUs", Definition="", SortOrder=0 },
            new RefPDActivityCreditType { Id=Guid.Parse("974a7fdc-88ee-44f8-a547-299bdef196e8"), Code="Quarter credits is the type of professional development credit awarded.", Description="QuarterCredits", Definition="", SortOrder=0 },
            new RefPDActivityCreditType { Id=Guid.Parse("e8209aa4-2555-4bff-8c2e-2a3bdb129d68"), Code="Semester credits is the type of professional development credit awarded.", Description="SemesterCredits", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPDActivityCreditType Pick List
         /// </summary>
        public static List<RefPDActivityCreditType> RefPDActivityCreditTypePickList = new List<RefPDActivityCreditType> =
        {
            new RefPDActivityCreditType { Id=Guid.Parse("68e4e064-1a2d-4299-9fcf-c5be6428ac55"), Code="Hours is the type of professional development credit awarded.", SortOrder=0 },
            new RefPDActivityCreditType { Id=Guid.Parse("7b147b86-afe1-46ec-9edc-53f150b5cdd4"), Code="Continuing Education Units is the type of professional development credit awarded.", SortOrder=0 },
            new RefPDActivityCreditType { Id=Guid.Parse("974a7fdc-88ee-44f8-a547-299bdef196e8"), Code="Quarter credits is the type of professional development credit awarded.", SortOrder=0 },
            new RefPDActivityCreditType { Id=Guid.Parse("e8209aa4-2555-4bff-8c2e-2a3bdb129d68"), Code="Semester credits is the type of professional development credit awarded.", SortOrder=0 },
       };
   }
}
