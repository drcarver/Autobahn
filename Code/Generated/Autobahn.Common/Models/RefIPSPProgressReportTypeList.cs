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
        public static List<RefIPSPProgressReportType> RefIPSPProgressReportTypeList = new List<RefIPSPProgressReportType>
        {
            new RefIPSPProgressReportType { Id=Guid.Parse("8b667afa-ed95-4eac-93e8-df99f2ae0c85"), Code="Other", Description="Other", Definition="The method by which parents are notified of the student's progress on annual goal is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportType { Id=Guid.Parse("a6d81f39-b409-40b1-92fb-c8fe52a4a986"), Code="Parentconference", Description="Parent conference", Definition="Parent conference is a method by which parents are notified of the student's progress on annual goal.", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportType { Id=Guid.Parse("f222aabd-7cc9-41f4-9e68-f6b63e237f4e"), Code="Progressreports", Description="Progress reports", Definition="Progress reports are a method by which parents are notified of the student's progress on annual goal.", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportType { Id=Guid.Parse("5dbe82eb-ded5-4053-9f96-11695a912762"), Code="Reportcard", Description="Report card", Definition="Report card is a method by which parents are notified of the student's progress on annual goal.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefIPSPProgressReportType Pick List
         /// </summary>
        public static List<RefIPSPProgressReportType> RefIPSPProgressReportTypePickList = new List<RefIPSPProgressReportType>
        {
            new RefIPSPProgressReportType { Id=Guid.Parse("8b667afa-ed95-4eac-93e8-df99f2ae0c85"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportType { Id=Guid.Parse("a6d81f39-b409-40b1-92fb-c8fe52a4a986"), Code="Parentconference", Description="Parent conference", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportType { Id=Guid.Parse("f222aabd-7cc9-41f4-9e68-f6b63e237f4e"), Code="Progressreports", Description="Progress reports", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportType { Id=Guid.Parse("5dbe82eb-ded5-4053-9f96-11695a912762"), Code="Reportcard", Description="Report card", SortOrder=Convert.ToDecimal("") },
       };
   }
}
