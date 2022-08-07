//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIPSPProgressReportTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIPSPProgressReportType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIPSPProgressReportTypeModel"> List
         /// </summary>
        public static List<RefIPSPProgressReportTypeModel> RefIPSPProgressReportTypeList = new List<RefIPSPProgressReportTypeModel>
        {
            new RefIPSPProgressReportType { Id=Guid.Parse("9d148373-5ecf-4eee-bbae-6e8419426c19"), Code="Other", Description="Other", Definition="The method by which parents are notified of the student's progress on annual goal is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportType { Id=Guid.Parse("b67da1a6-45fc-4737-a314-038ad8a18319"), Code="Parentconference", Description="Parent conference", Definition="Parent conference is a method by which parents are notified of the student's progress on annual goal.", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportType { Id=Guid.Parse("2f11b694-adff-4e60-80d1-762c651efcaa"), Code="Progressreports", Description="Progress reports", Definition="Progress reports are a method by which parents are notified of the student's progress on annual goal.", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportType { Id=Guid.Parse("16ab7cef-9277-402d-a598-2da7d9f320da"), Code="Reportcard", Description="Report card", Definition="Report card is a method by which parents are notified of the student's progress on annual goal.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefIPSPProgressReportType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIPSPProgressReportTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIPSPProgressReportType { Id=Guid.Parse("9d148373-5ecf-4eee-bbae-6e8419426c19"), Description="Other", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportType { Id=Guid.Parse("b67da1a6-45fc-4737-a314-038ad8a18319"), Description="Parent conference", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportType { Id=Guid.Parse("2f11b694-adff-4e60-80d1-762c651efcaa"), Description="Progress reports", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportType { Id=Guid.Parse("16ab7cef-9277-402d-a598-2da7d9f320da"), Description="Report card", SortOrder=Convert.ToDecimal("") },
       };
   }
}
