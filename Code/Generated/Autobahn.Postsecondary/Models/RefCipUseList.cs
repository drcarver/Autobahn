//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefCipUseList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefCipUse Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCipUseModel"> List
         /// </summary>
        public static List<RefCipUseModel> RefCipUseList = new List<RefCipUseModel>
        {
            new RefCipUse { Id=Guid.Parse("4a98fb76-d673-4e7a-aae3-901c8f52dbe1"), Code="PrimaryEnrollment", Description="Primary enrollment", Definition="The related Classification of Instructional Program code is referencing primary enrollment.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCipUse { Id=Guid.Parse("5320a11c-3bf3-4c9f-8977-5ae03b85605c"), Code="AdditionalEnrollment", Description="Additional enrollment", Definition="The related Classification of Instructional Program code is referencing additional enrollment.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCipUse { Id=Guid.Parse("3d1143e2-082d-48a7-9780-b9e5ee1a6250"), Code="PrimaryCompletion", Description="Primary completion", Definition="The related Classification of Instructional Program code is referencing primary completion.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCipUse { Id=Guid.Parse("385fc352-dbb2-4ead-8433-d2ff851ae5a0"), Code="AdditionalCompletion", Description="Additional completion", Definition="The related Classification of Instructional Program code is referencing additional completion.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefCipUse Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCipUseViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCipUse { Id=Guid.Parse("4a98fb76-d673-4e7a-aae3-901c8f52dbe1"), Description="Primary enrollment", SortOrder=Convert.ToDecimal("1.00") },
            new RefCipUse { Id=Guid.Parse("5320a11c-3bf3-4c9f-8977-5ae03b85605c"), Description="Additional enrollment", SortOrder=Convert.ToDecimal("2.00") },
            new RefCipUse { Id=Guid.Parse("3d1143e2-082d-48a7-9780-b9e5ee1a6250"), Description="Primary completion", SortOrder=Convert.ToDecimal("3.00") },
            new RefCipUse { Id=Guid.Parse("385fc352-dbb2-4ead-8433-d2ff851ae5a0"), Description="Additional completion", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
