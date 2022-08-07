//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   RefCredentialDefAgentRoleTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The list of RefCredentialDefAgentRoleType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCredentialDefAgentRoleTypeModel"> List
         /// </summary>
        public static List<RefCredentialDefAgentRoleTypeModel> RefCredentialDefAgentRoleTypeList = new List<RefCredentialDefAgentRoleTypeModel>
        {
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("524b1cea-1049-4eef-84c8-97063b6d9e28"), Code="accreditedBy", Description="Accredited By", Definition="Quality assurance organization that provides official authorization to, or approval of, a credential, organization, assessment, or learning opportunity.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("de7d83ff-2328-438a-bb23-f8b254f02c84"), Code="approvedBy", Description="Approved By", Definition="Organization that pronounces favorable judgment for this credential, assessment, learning opportunity, or organization.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("a5995d4a-cbea-4a3d-83bd-ffc956cf220b"), Code="offeredBy", Description="Offered By", Definition="Agent that offers the resource.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("9e2998fa-a44b-49df-98c2-f5afc361060b"), Code="ownedBy", Description="Owned By", Definition="Organization or person with an enforceable claim or legal title to the Credential Definition resource.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("37f4c50e-560f-4369-b49f-af6a89c08647"), Code="recognizedBy", Description="Recognized By", Definition="Agent that acknowledges the validity of the credential, learning opportunity, or assessment.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("b96417a6-f82c-457b-91be-4cf465d3c2bd"), Code="regulatedBy", Description="Regulated By", Definition="Quality assurance organization that enforces the legal requirements of the credential, learning resource, or assessment.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("a6f83a0b-9ac0-49f0-b156-301064ccd4f6"), Code="renewedBy", Description="Renewed By", Definition="Organization or person that handles the renewal of the credential.", SortOrder=Convert.ToDecimal("7.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("53267337-f669-4747-9300-65c2222f39ea"), Code="revokedBy", Description="Revoked By", Definition="Organization or person that handles revocation of an awarded credential due to violations or failure to renew.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefCredentialDefAgentRoleType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCredentialDefAgentRoleTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("524b1cea-1049-4eef-84c8-97063b6d9e28"), Description="Accredited By", SortOrder=Convert.ToDecimal("1.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("de7d83ff-2328-438a-bb23-f8b254f02c84"), Description="Approved By", SortOrder=Convert.ToDecimal("2.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("a5995d4a-cbea-4a3d-83bd-ffc956cf220b"), Description="Offered By", SortOrder=Convert.ToDecimal("3.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("9e2998fa-a44b-49df-98c2-f5afc361060b"), Description="Owned By", SortOrder=Convert.ToDecimal("4.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("37f4c50e-560f-4369-b49f-af6a89c08647"), Description="Recognized By", SortOrder=Convert.ToDecimal("5.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("b96417a6-f82c-457b-91be-4cf465d3c2bd"), Description="Regulated By", SortOrder=Convert.ToDecimal("6.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("a6f83a0b-9ac0-49f0-b156-301064ccd4f6"), Description="Renewed By", SortOrder=Convert.ToDecimal("7.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("53267337-f669-4747-9300-65c2222f39ea"), Description="Revoked By", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
