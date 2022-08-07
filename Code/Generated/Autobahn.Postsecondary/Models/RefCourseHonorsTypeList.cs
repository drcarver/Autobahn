//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefCourseHonorsTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefCourseHonorsType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseHonorsTypeModel"> List
         /// </summary>
        public static List<RefCourseHonorsTypeModel> RefCourseHonorsTypeList = new List<RefCourseHonorsTypeModel>
        {
            new RefCourseHonorsType { Id=Guid.Parse("90da7903-c323-476d-a0b4-a87a5784be14"), Code="Honors", Description="Honors", Definition="The course is counted as an honors course.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseHonorsType { Id=Guid.Parse("f11177e7-db75-4295-a696-02ec16f8e474"), Code="HonorsOption", Description="Honors option", Definition="The course can be counted as an honors course.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefCourseHonorsType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCourseHonorsTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCourseHonorsType { Id=Guid.Parse("90da7903-c323-476d-a0b4-a87a5784be14"), Description="Honors", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseHonorsType { Id=Guid.Parse("f11177e7-db75-4295-a696-02ec16f8e474"), Description="Honors option", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
