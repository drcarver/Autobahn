//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefPsStudentLevelList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefPsStudentLevel Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPsStudentLevelModel"> List
         /// </summary>
        public static List<RefPsStudentLevelModel> RefPsStudentLevelList = new List<RefPsStudentLevelModel>
        {
            new RefPsStudentLevel { Id=Guid.Parse("b36a68dd-0153-4832-a906-f568fc05e2b4"), Code="Undergraduate", Description="Undergraduate", Definition="The person enrolling in credit-granting courses at the postsecondary institution is at the undergraduate level.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPsStudentLevel { Id=Guid.Parse("fc6bcc0e-f00b-48ca-a254-7bc89aa507df"), Code="Graduate", Description="Graduate", Definition="The person enrolling in credit-granting courses at the postsecondary institution is at the graduate level.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefPsStudentLevel Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPsStudentLevelViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPsStudentLevel { Id=Guid.Parse("b36a68dd-0153-4832-a906-f568fc05e2b4"), Description="Undergraduate", SortOrder=Convert.ToDecimal("1.00") },
            new RefPsStudentLevel { Id=Guid.Parse("fc6bcc0e-f00b-48ca-a254-7bc89aa507df"), Description="Graduate", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
