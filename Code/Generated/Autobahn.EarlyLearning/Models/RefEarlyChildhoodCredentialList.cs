//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefEarlyChildhoodCredentialList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefEarlyChildhoodCredential Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEarlyChildhoodCredential"> List
         /// </summary>
        public static List<RefEarlyChildhoodCredential> RefEarlyChildhoodCredentialList = new List<RefEarlyChildhoodCredential> =
        {
            new RefEarlyChildhoodCredential { Id=Guid.Parse("ea0af9dc-daa6-4311-a945-147c7cdec5b4"), Code="Child Development Associate (CDA) is the credential related to early childhood education or development held by a person.", Description="ChildDevelopmentAssociate", Definition="", SortOrder=0 },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("93c21bb4-8216-4d27-873d-2b0104cb2736"), Code="Directors Level Credential is the credential related to early childhood education or development held by a person.", Description="DirectorsLevelCredential", Definition="", SortOrder=0 },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("e4c62a25-7ab8-4041-96f1-b8fe2b861b45"), Code="State Awarded Credential for Infant/Toddler is the credential related to early childhood education or development held by a person.", Description="StateInfantToddler", Definition="", SortOrder=0 },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("1c57e8a9-c79b-437c-9cbf-5c81887563db"), Code="State Awarded Preschool Credential is the credential related to early childhood education or development held by a person.", Description="StatePreschool", Definition="", SortOrder=0 },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("7be817ca-fa8e-448f-94b2-a49b7dd6b75f"), Code="State Awarded School-Age Credential is the credential related to early childhood education or development held by a person.", Description="StateSchoolAge", Definition="", SortOrder=0 },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("588100a1-81d4-4f43-9708-15c363a606ae"), Code="The credential related to early childhood education or development held by a person is in a category not yet defined in CEDS.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefEarlyChildhoodCredential Pick List
         /// </summary>
        public static List<RefEarlyChildhoodCredential> RefEarlyChildhoodCredentialPickList = new List<RefEarlyChildhoodCredential> =
        {
            new RefEarlyChildhoodCredential { Id=Guid.Parse("ea0af9dc-daa6-4311-a945-147c7cdec5b4"), Code="Child Development Associate (CDA) is the credential related to early childhood education or development held by a person.", SortOrder=0 },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("93c21bb4-8216-4d27-873d-2b0104cb2736"), Code="Directors Level Credential is the credential related to early childhood education or development held by a person.", SortOrder=0 },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("e4c62a25-7ab8-4041-96f1-b8fe2b861b45"), Code="State Awarded Credential for Infant/Toddler is the credential related to early childhood education or development held by a person.", SortOrder=0 },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("1c57e8a9-c79b-437c-9cbf-5c81887563db"), Code="State Awarded Preschool Credential is the credential related to early childhood education or development held by a person.", SortOrder=0 },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("7be817ca-fa8e-448f-94b2-a49b7dd6b75f"), Code="State Awarded School-Age Credential is the credential related to early childhood education or development held by a person.", SortOrder=0 },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("588100a1-81d4-4f43-9708-15c363a606ae"), Code="The credential related to early childhood education or development held by a person is in a category not yet defined in CEDS.", SortOrder=0 },
       };
   }
}
