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
        public static List<RefCipUse> RefCipUseList = new List<RefCipUse> =
        {
            new RefCipUse { Id=Guid.Parse("24f41ac7-d885-48ef-bcf2-2be212cfce5d"), Code="The related Classification of Instructional Program code is referencing primary enrollment.", Description="PrimaryEnrollment", Definition="", SortOrder=0 },
            new RefCipUse { Id=Guid.Parse("dd027a0b-1318-4a2b-a6c3-908be40366a5"), Code="The related Classification of Instructional Program code is referencing additional enrollment.", Description="AdditionalEnrollment", Definition="", SortOrder=0 },
            new RefCipUse { Id=Guid.Parse("f63f8f19-3d11-4c75-9c1c-608e461f234f"), Code="The related Classification of Instructional Program code is referencing primary completion.", Description="PrimaryCompletion", Definition="", SortOrder=0 },
            new RefCipUse { Id=Guid.Parse("f2ae145a-b669-42af-b983-5c1b6008207f"), Code="The related Classification of Instructional Program code is referencing additional completion.", Description="AdditionalCompletion", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCipUse Pick List
         /// </summary>
        public static List<RefCipUse> RefCipUsePickList = new List<RefCipUse> =
        {
            new RefCipUse { Id=Guid.Parse("24f41ac7-d885-48ef-bcf2-2be212cfce5d"), Code="The related Classification of Instructional Program code is referencing primary enrollment.", SortOrder=0 },
            new RefCipUse { Id=Guid.Parse("dd027a0b-1318-4a2b-a6c3-908be40366a5"), Code="The related Classification of Instructional Program code is referencing additional enrollment.", SortOrder=0 },
            new RefCipUse { Id=Guid.Parse("f63f8f19-3d11-4c75-9c1c-608e461f234f"), Code="The related Classification of Instructional Program code is referencing primary completion.", SortOrder=0 },
            new RefCipUse { Id=Guid.Parse("f2ae145a-b669-42af-b983-5c1b6008207f"), Code="The related Classification of Instructional Program code is referencing additional completion.", SortOrder=0 },
       };
   }
}
