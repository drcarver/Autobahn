//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEmployedPriorToEnrollmentList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEmployedPriorToEnrollment Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEmployedPriorToEnrollmentModel"> List
         /// </summary>
        public static List<RefEmployedPriorToEnrollmentModel> RefEmployedPriorToEnrollmentList = new List<RefEmployedPriorToEnrollmentModel>
        {
            new RefEmployedPriorToEnrollment { Id=Guid.Parse("f3584d27-9646-4d9b-a6b6-001e538995a2"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmployedPriorToEnrollment { Id=Guid.Parse("c77af8bb-4a09-499c-ba55-7c32f112d27f"), Code="Unknown", Description="Unknown", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefEmployedPriorToEnrollment Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefEmployedPriorToEnrollmentViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefEmployedPriorToEnrollment { Id=Guid.Parse("f3584d27-9646-4d9b-a6b6-001e538995a2"), Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmployedPriorToEnrollment { Id=Guid.Parse("c77af8bb-4a09-499c-ba55-7c32f112d27f"), Description="Unknown", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
