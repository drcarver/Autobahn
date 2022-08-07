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
        /// The complete <see cref="RefEarlyChildhoodCredentialModel"> List
         /// </summary>
        public static List<RefEarlyChildhoodCredentialModel> RefEarlyChildhoodCredentialList = new List<RefEarlyChildhoodCredentialModel>
        {
            new RefEarlyChildhoodCredential { Id=Guid.Parse("e0468425-f9a8-4b01-b2d1-e4b90940ebbe"), Code="ChildDevelopmentAssociate", Description="Child Development Associate (CDA)", Definition="Child Development Associate (CDA) is the credential related to early childhood education or development held by a person.", SortOrder=Convert.ToDecimal("2.00") },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("bd03753a-50e4-4ddb-957b-b805936cb0bc"), Code="DirectorsLevelCredential", Description="Directors Level Credential", Definition="Directors Level Credential is the credential related to early childhood education or development held by a person.", SortOrder=Convert.ToDecimal("3.00") },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("6131eaf5-62d8-45ea-9ad7-dc25de977738"), Code="StateInfantToddler", Description="State Awarded Credential for Infant/Toddler", Definition="State Awarded Credential for Infant/Toddler is the credential related to early childhood education or development held by a person.", SortOrder=Convert.ToDecimal("4.00") },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("dfc076f0-7ae7-4186-8302-192bc95abe40"), Code="StatePreschool", Description="State Awarded Preschool Credential", Definition="State Awarded Preschool Credential is the credential related to early childhood education or development held by a person.", SortOrder=Convert.ToDecimal("5.00") },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("f4ec70f7-7863-4318-ac9a-a7a09f2db22a"), Code="StateSchoolAge", Description="State Awarded School-Age Credential", Definition="State Awarded School-Age Credential is the credential related to early childhood education or development held by a person.", SortOrder=Convert.ToDecimal("6.00") },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("bee1f5d5-b853-47b8-a151-e1967ab1dcd0"), Code="Other", Description="Other", Definition="The credential related to early childhood education or development held by a person is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The Reference RefEarlyChildhoodCredential Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefEarlyChildhoodCredentialViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefEarlyChildhoodCredential { Id=Guid.Parse("e0468425-f9a8-4b01-b2d1-e4b90940ebbe"), Description="Child Development Associate (CDA)", SortOrder=Convert.ToDecimal("2.00") },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("bd03753a-50e4-4ddb-957b-b805936cb0bc"), Description="Directors Level Credential", SortOrder=Convert.ToDecimal("3.00") },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("6131eaf5-62d8-45ea-9ad7-dc25de977738"), Description="State Awarded Credential for Infant/Toddler", SortOrder=Convert.ToDecimal("4.00") },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("dfc076f0-7ae7-4186-8302-192bc95abe40"), Description="State Awarded Preschool Credential", SortOrder=Convert.ToDecimal("5.00") },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("f4ec70f7-7863-4318-ac9a-a7a09f2db22a"), Description="State Awarded School-Age Credential", SortOrder=Convert.ToDecimal("6.00") },
            new RefEarlyChildhoodCredential { Id=Guid.Parse("bee1f5d5-b853-47b8-a151-e1967ab1dcd0"), Description="Other", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
