//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefControlOfInstitutionList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefControlOfInstitution Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefControlOfInstitution"> List
         /// </summary>
        public static List<RefControlOfInstitution> RefControlOfInstitutionList = new List<RefControlOfInstitution> =
        {
            new RefControlOfInstitution { Id=Guid.Parse("a664ada1-14c8-4e39-b5e2-40c7c18cac62"), Code="The postsecondary institution is operated by publicly elected or appointed officials.", Description="Public", Definition="", SortOrder=0 },
            new RefControlOfInstitution { Id=Guid.Parse("e74d4014-4127-4f35-a525-9a37e1204a8d"), Code="The postsecondary institution is operated by privately elected or appointed officials and is organized as a not for profit entity.", Description="PrivateNFP", Definition="", SortOrder=0 },
            new RefControlOfInstitution { Id=Guid.Parse("fc04ba46-f12b-49c7-b59a-64dbc1da4654"), Code="The postsecondary institution is operated by privately elected or appointed officials and is organized as a for profit entity.", Description="PrivateFP", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefControlOfInstitution Pick List
         /// </summary>
        public static List<RefControlOfInstitution> RefControlOfInstitutionPickList = new List<RefControlOfInstitution> =
        {
            new RefControlOfInstitution { Id=Guid.Parse("a664ada1-14c8-4e39-b5e2-40c7c18cac62"), Code="The postsecondary institution is operated by publicly elected or appointed officials.", SortOrder=0 },
            new RefControlOfInstitution { Id=Guid.Parse("e74d4014-4127-4f35-a525-9a37e1204a8d"), Code="The postsecondary institution is operated by privately elected or appointed officials and is organized as a not for profit entity.", SortOrder=0 },
            new RefControlOfInstitution { Id=Guid.Parse("fc04ba46-f12b-49c7-b59a-64dbc1da4654"), Code="The postsecondary institution is operated by privately elected or appointed officials and is organized as a for profit entity.", SortOrder=0 },
       };
   }
}
