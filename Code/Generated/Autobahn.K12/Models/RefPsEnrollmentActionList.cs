//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefPsEnrollmentActionList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefPsEnrollmentAction Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPsEnrollmentActionModel"> List
         /// </summary>
        public static List<RefPsEnrollmentActionModel> RefPsEnrollmentActionList = new List<RefPsEnrollmentActionModel>
        {
            new RefPsEnrollmentAction { Id=Guid.Parse("95d5099f-c98b-4677-bb9b-25bee6cac738"), Code="NoInformation", Description="No information", Definition="No information is available about the action taken with respect to postsecondary enrollment by the student who graduated from the school, LEA or state in the past two years.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPsEnrollmentAction { Id=Guid.Parse("283225ba-9de3-44be-9adf-382bf8f6831c"), Code="Enrolled", Description="Enrolled", Definition="The student who graduated from the school, LEA or state in the past two years enrolled in a postsecondary institution.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPsEnrollmentAction { Id=Guid.Parse("9e4854bf-3545-4da4-a9f7-369c9683cbac"), Code="NotEnrolled", Description="Not enrolled", Definition="The student who graduated from the school, LEA or state in the past two years was NOT  enrolled in a postsecondary institution.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefPsEnrollmentAction Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPsEnrollmentActionViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPsEnrollmentAction { Id=Guid.Parse("95d5099f-c98b-4677-bb9b-25bee6cac738"), Description="No information", SortOrder=Convert.ToDecimal("1.00") },
            new RefPsEnrollmentAction { Id=Guid.Parse("283225ba-9de3-44be-9adf-382bf8f6831c"), Description="Enrolled", SortOrder=Convert.ToDecimal("2.00") },
            new RefPsEnrollmentAction { Id=Guid.Parse("9e4854bf-3545-4da4-a9f7-369c9683cbac"), Description="Not enrolled", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
