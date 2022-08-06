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
        /// The complete <see cref="RefCipUse"> List
         /// </summary>
        public static List<RefCipUse> RefCipUseList = new List<RefCipUse>
        {
            new RefCipUse { Id=Guid.Parse("58dab0b8-87c4-4827-bf8a-828b9d72a2ce"), Code="PrimaryEnrollment", Description="Primary enrollment", Definition="The related Classification of Instructional Program code is referencing primary enrollment.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCipUse { Id=Guid.Parse("d341d7e1-c303-4086-b20a-aca70188aa02"), Code="AdditionalEnrollment", Description="Additional enrollment", Definition="The related Classification of Instructional Program code is referencing additional enrollment.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCipUse { Id=Guid.Parse("2ca74c82-f94f-444f-85e5-7b9e96ff0fdc"), Code="PrimaryCompletion", Description="Primary completion", Definition="The related Classification of Instructional Program code is referencing primary completion.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCipUse { Id=Guid.Parse("31dcbe91-5df3-40b4-9a4a-3d514e91ce51"), Code="AdditionalCompletion", Description="Additional completion", Definition="The related Classification of Instructional Program code is referencing additional completion.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefCipUse Pick List
         /// </summary>
        public static List<RefCipUse> RefCipUsePickList = new List<RefCipUse>
        {
            new RefCipUse { Id=Guid.Parse("58dab0b8-87c4-4827-bf8a-828b9d72a2ce"), Code="PrimaryEnrollment", Description="Primary enrollment", SortOrder=Convert.ToDecimal("1.00") },
            new RefCipUse { Id=Guid.Parse("d341d7e1-c303-4086-b20a-aca70188aa02"), Code="AdditionalEnrollment", Description="Additional enrollment", SortOrder=Convert.ToDecimal("2.00") },
            new RefCipUse { Id=Guid.Parse("2ca74c82-f94f-444f-85e5-7b9e96ff0fdc"), Code="PrimaryCompletion", Description="Primary completion", SortOrder=Convert.ToDecimal("3.00") },
            new RefCipUse { Id=Guid.Parse("31dcbe91-5df3-40b4-9a4a-3d514e91ce51"), Code="AdditionalCompletion", Description="Additional completion", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
