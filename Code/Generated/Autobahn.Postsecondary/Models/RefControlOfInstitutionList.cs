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
        public static List<RefControlOfInstitution> RefControlOfInstitutionList = new List<RefControlOfInstitution>
        {
            new RefControlOfInstitution { Id=Guid.Parse("896433dc-2073-4f6b-8193-06ff44ac12a7"), Code="Public", Description="Public", Definition="The postsecondary institution is operated by publicly elected or appointed officials.", SortOrder=Convert.ToDecimal("1.00") },
            new RefControlOfInstitution { Id=Guid.Parse("220c64fe-9b4e-4b8c-a0c5-ca8448a35037"), Code="PrivateNFP", Description="Private, not for profit", Definition="The postsecondary institution is operated by privately elected or appointed officials and is organized as a not for profit entity.", SortOrder=Convert.ToDecimal("2.00") },
            new RefControlOfInstitution { Id=Guid.Parse("e572c793-a96c-4d11-b458-0fd46b73433c"), Code="PrivateFP", Description="Private, for profit", Definition="The postsecondary institution is operated by privately elected or appointed officials and is organized as a for profit entity.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefControlOfInstitution Pick List
         /// </summary>
        public static List<RefControlOfInstitution> RefControlOfInstitutionPickList = new List<RefControlOfInstitution>
        {
            new RefControlOfInstitution { Id=Guid.Parse("896433dc-2073-4f6b-8193-06ff44ac12a7"), Code="Public", Description="Public", SortOrder=Convert.ToDecimal("1.00") },
            new RefControlOfInstitution { Id=Guid.Parse("220c64fe-9b4e-4b8c-a0c5-ca8448a35037"), Code="PrivateNFP", Description="Private, not for profit", SortOrder=Convert.ToDecimal("2.00") },
            new RefControlOfInstitution { Id=Guid.Parse("e572c793-a96c-4d11-b458-0fd46b73433c"), Code="PrivateFP", Description="Private, for profit", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
