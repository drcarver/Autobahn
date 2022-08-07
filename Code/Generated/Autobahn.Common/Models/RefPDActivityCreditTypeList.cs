//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDActivityCreditTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPDActivityCreditType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPDActivityCreditTypeModel"> List
         /// </summary>
        public static List<RefPDActivityCreditTypeModel> RefPDActivityCreditTypeList = new List<RefPDActivityCreditTypeModel>
        {
            new RefPDActivityCreditType { Id=Guid.Parse("f326ea4a-e6c0-4b81-9209-5c3b59a26a94"), Code="Hours", Description="Hours", Definition="Hours is the type of professional development credit awarded.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDActivityCreditType { Id=Guid.Parse("dc27649b-9bc1-49b8-9dcb-0b9c7a7a5d72"), Code="CEUs", Description="Continuing Education Units", Definition="Continuing Education Units is the type of professional development credit awarded.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPDActivityCreditType { Id=Guid.Parse("ef484511-3921-4e75-a364-ff8f7d8f950e"), Code="QuarterCredits", Description="Quarter credits", Definition="Quarter credits is the type of professional development credit awarded.", SortOrder=Convert.ToDecimal("6.00") },
            new RefPDActivityCreditType { Id=Guid.Parse("cb386edd-3811-490c-9edc-44371d02ffe2"), Code="SemesterCredits", Description="Semester credits", Definition="Semester credits is the type of professional development credit awarded.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefPDActivityCreditType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPDActivityCreditTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPDActivityCreditType { Id=Guid.Parse("f326ea4a-e6c0-4b81-9209-5c3b59a26a94"), Description="Hours", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDActivityCreditType { Id=Guid.Parse("dc27649b-9bc1-49b8-9dcb-0b9c7a7a5d72"), Description="Continuing Education Units", SortOrder=Convert.ToDecimal("4.00") },
            new RefPDActivityCreditType { Id=Guid.Parse("ef484511-3921-4e75-a364-ff8f7d8f950e"), Description="Quarter credits", SortOrder=Convert.ToDecimal("6.00") },
            new RefPDActivityCreditType { Id=Guid.Parse("cb386edd-3811-490c-9edc-44371d02ffe2"), Description="Semester credits", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
