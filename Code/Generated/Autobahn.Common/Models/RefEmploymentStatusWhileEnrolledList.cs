//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEmploymentStatusWhileEnrolledList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEmploymentStatusWhileEnrolled Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEmploymentStatusWhileEnrolledModel"> List
         /// </summary>
        public static List<RefEmploymentStatusWhileEnrolledModel> RefEmploymentStatusWhileEnrolledList = new List<RefEmploymentStatusWhileEnrolledModel>
        {
            new RefEmploymentStatusWhileEnrolled { Id=Guid.Parse("2d9cee4d-82a8-4fe3-b121-aed111c9f804"), Code="01", Description="Full-time", Definition="Full-time is the individual's employment status while enrolled.", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmploymentStatusWhileEnrolled { Id=Guid.Parse("731828ba-df46-4332-99af-2a734e64f5a3"), Code="02", Description="Less than full-time but at least half-time", Definition="Less than full-time but at least half-time is the individual's employment status while enrolled.", SortOrder=Convert.ToDecimal("3.00") },
            new RefEmploymentStatusWhileEnrolled { Id=Guid.Parse("6cf3bf87-8181-4374-9713-847924a599c7"), Code="03", Description="Less than half-time", Definition="Less than half-time is the individual's employment status while enrolled.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefEmploymentStatusWhileEnrolled Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefEmploymentStatusWhileEnrolledViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefEmploymentStatusWhileEnrolled { Id=Guid.Parse("2d9cee4d-82a8-4fe3-b121-aed111c9f804"), Description="Full-time", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmploymentStatusWhileEnrolled { Id=Guid.Parse("731828ba-df46-4332-99af-2a734e64f5a3"), Description="Less than full-time but at least half-time", SortOrder=Convert.ToDecimal("3.00") },
            new RefEmploymentStatusWhileEnrolled { Id=Guid.Parse("6cf3bf87-8181-4374-9713-847924a599c7"), Description="Less than half-time", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
