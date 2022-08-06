//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIPSPProgressReportTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIPSPProgressReportType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIPSPProgressReportType"> List
         /// </summary>
        public static List<RefIPSPProgressReportType> RefIPSPProgressReportTypeList = new List<RefIPSPProgressReportType> =
        {
            new RefIPSPProgressReportType { Id=Guid.Parse("e559543a-e43b-446b-b41c-4f9029da5350"), Code="The method by which parents are notified of the student's progress on annual goal is in a category not yet defined in CEDS.", Description="Other", Definition="", SortOrder=0 },
            new RefIPSPProgressReportType { Id=Guid.Parse("664c3f8b-0bf7-4e28-915d-8662679e6a88"), Code="Parent conference is a method by which parents are notified of the student's progress on annual goal.", Description="Parentconference", Definition="", SortOrder=0 },
            new RefIPSPProgressReportType { Id=Guid.Parse("4a4e0aa3-1af5-44b7-8f51-74e147a72ce6"), Code="Progress reports are a method by which parents are notified of the student's progress on annual goal.", Description="Progressreports", Definition="", SortOrder=0 },
            new RefIPSPProgressReportType { Id=Guid.Parse("a901f3a9-d113-443c-ab1d-8acf9af4fa7e"), Code="Report card is a method by which parents are notified of the student's progress on annual goal.", Description="Reportcard", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefIPSPProgressReportType Pick List
         /// </summary>
        public static List<RefIPSPProgressReportType> RefIPSPProgressReportTypePickList = new List<RefIPSPProgressReportType> =
        {
            new RefIPSPProgressReportType { Id=Guid.Parse("e559543a-e43b-446b-b41c-4f9029da5350"), Code="The method by which parents are notified of the student's progress on annual goal is in a category not yet defined in CEDS.", SortOrder=0 },
            new RefIPSPProgressReportType { Id=Guid.Parse("664c3f8b-0bf7-4e28-915d-8662679e6a88"), Code="Parent conference is a method by which parents are notified of the student's progress on annual goal.", SortOrder=0 },
            new RefIPSPProgressReportType { Id=Guid.Parse("4a4e0aa3-1af5-44b7-8f51-74e147a72ce6"), Code="Progress reports are a method by which parents are notified of the student's progress on annual goal.", SortOrder=0 },
            new RefIPSPProgressReportType { Id=Guid.Parse("a901f3a9-d113-443c-ab1d-8acf9af4fa7e"), Code="Report card is a method by which parents are notified of the student's progress on annual goal.", SortOrder=0 },
       };
   }
}
