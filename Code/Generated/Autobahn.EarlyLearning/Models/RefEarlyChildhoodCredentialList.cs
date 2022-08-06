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
        public static List<RefEarlyChildhoodCredential> RefEarlyChildhoodCredentialList = new List<RefEarlyChildhoodCredential>
        {
            new RefEarlyChildhoodCredential { Id=Guid.Parse("df5a2e72-288b-44bf-b485-9a9341790f5a"), Code="ChildDevelopmentAssociate", Description="Child Development Associate (CDA)", Definition="Child Development Associate (CDA) is the credential related to early childhood education or development held by a person.", SortOrder=Convert.ToDecimal("2.00") },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("bc792064-d2bf-4c3d-b23e-feb4e1701bb0"), Code="DirectorsLevelCredential", Description="Directors Level Credential", Definition="Directors Level Credential is the credential related to early childhood education or development held by a person.", SortOrder=Convert.ToDecimal("3.00") },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("f9aad5ac-fda0-4037-96b7-26fb34727163"), Code="StateInfantToddler", Description="State Awarded Credential for Infant/Toddler", Definition="State Awarded Credential for Infant/Toddler is the credential related to early childhood education or development held by a person.", SortOrder=Convert.ToDecimal("4.00") },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("040bf509-9710-439f-9bb7-6a65ecb9bd4c"), Code="StatePreschool", Description="State Awarded Preschool Credential", Definition="State Awarded Preschool Credential is the credential related to early childhood education or development held by a person.", SortOrder=Convert.ToDecimal("5.00") },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("bc70b598-cc9c-4d04-883f-c04310adabf3"), Code="StateSchoolAge", Description="State Awarded School-Age Credential", Definition="State Awarded School-Age Credential is the credential related to early childhood education or development held by a person.", SortOrder=Convert.ToDecimal("6.00") },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("c0464f04-71a9-4e29-b1ef-ebbc8dd55438"), Code="Other", Description="Other", Definition="The credential related to early childhood education or development held by a person is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The RefEarlyChildhoodCredential Pick List
         /// </summary>
        public static List<RefEarlyChildhoodCredential> RefEarlyChildhoodCredentialPickList = new List<RefEarlyChildhoodCredential>
        {
            new RefEarlyChildhoodCredential { Id=Guid.Parse("df5a2e72-288b-44bf-b485-9a9341790f5a"), Code="ChildDevelopmentAssociate", Description="Child Development Associate (CDA)", SortOrder=Convert.ToDecimal("2.00") },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("bc792064-d2bf-4c3d-b23e-feb4e1701bb0"), Code="DirectorsLevelCredential", Description="Directors Level Credential", SortOrder=Convert.ToDecimal("3.00") },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("f9aad5ac-fda0-4037-96b7-26fb34727163"), Code="StateInfantToddler", Description="State Awarded Credential for Infant/Toddler", SortOrder=Convert.ToDecimal("4.00") },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("040bf509-9710-439f-9bb7-6a65ecb9bd4c"), Code="StatePreschool", Description="State Awarded Preschool Credential", SortOrder=Convert.ToDecimal("5.00") },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("bc70b598-cc9c-4d04-883f-c04310adabf3"), Code="StateSchoolAge", Description="State Awarded School-Age Credential", SortOrder=Convert.ToDecimal("6.00") },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("c0464f04-71a9-4e29-b1ef-ebbc8dd55438"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
