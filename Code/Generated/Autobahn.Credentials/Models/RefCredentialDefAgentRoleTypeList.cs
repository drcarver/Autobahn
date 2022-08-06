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
        /// The complete <see cref="RefCredentialDefAgentRoleType"> List
         /// </summary>
        public static List<RefCredentialDefAgentRoleType> RefCredentialDefAgentRoleTypeList = new List<RefCredentialDefAgentRoleType>
        {
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("36e2efef-ce57-4d2c-87c9-ffa7f78caaa9"), Code="accreditedBy", Description="Accredited By", Definition="Quality assurance organization that provides official authorization to, or approval of, a credential, organization, assessment, or learning opportunity.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("b6877710-88d4-42c8-8cb8-02562d0630a0"), Code="approvedBy", Description="Approved By", Definition="Organization that pronounces favorable judgment for this credential, assessment, learning opportunity, or organization.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("f765886d-d770-4957-8c33-6f223ac4b80c"), Code="offeredBy", Description="Offered By", Definition="Agent that offers the resource.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("ab38ebc9-341f-403b-a884-e441b91d0142"), Code="ownedBy", Description="Owned By", Definition="Organization or person with an enforceable claim or legal title to the Credential Definition resource.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("05ed8400-ecc7-4561-b95d-a66ac9e146f5"), Code="recognizedBy", Description="Recognized By", Definition="Agent that acknowledges the validity of the credential, learning opportunity, or assessment.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("b2e0b7e8-2b48-400b-a226-1b031e1e9606"), Code="regulatedBy", Description="Regulated By", Definition="Quality assurance organization that enforces the legal requirements of the credential, learning resource, or assessment.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("e099ffde-72ec-432f-8371-74040aad6bd7"), Code="renewedBy", Description="Renewed By", Definition="Organization or person that handles the renewal of the credential.", SortOrder=Convert.ToDecimal("7.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("bdf5c7ba-f031-4606-83e7-f093774a26b0"), Code="revokedBy", Description="Revoked By", Definition="Organization or person that handles revocation of an awarded credential due to violations or failure to renew.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The RefCredentialDefAgentRoleType Pick List
         /// </summary>
        public static List<RefCredentialDefAgentRoleType> RefCredentialDefAgentRoleTypePickList = new List<RefCredentialDefAgentRoleType>
        {
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("36e2efef-ce57-4d2c-87c9-ffa7f78caaa9"), Code="accreditedBy", Description="Accredited By", SortOrder=Convert.ToDecimal("1.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("b6877710-88d4-42c8-8cb8-02562d0630a0"), Code="approvedBy", Description="Approved By", SortOrder=Convert.ToDecimal("2.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("f765886d-d770-4957-8c33-6f223ac4b80c"), Code="offeredBy", Description="Offered By", SortOrder=Convert.ToDecimal("3.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("ab38ebc9-341f-403b-a884-e441b91d0142"), Code="ownedBy", Description="Owned By", SortOrder=Convert.ToDecimal("4.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("05ed8400-ecc7-4561-b95d-a66ac9e146f5"), Code="recognizedBy", Description="Recognized By", SortOrder=Convert.ToDecimal("5.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("b2e0b7e8-2b48-400b-a226-1b031e1e9606"), Code="regulatedBy", Description="Regulated By", SortOrder=Convert.ToDecimal("6.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("e099ffde-72ec-432f-8371-74040aad6bd7"), Code="renewedBy", Description="Renewed By", SortOrder=Convert.ToDecimal("7.00") },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("bdf5c7ba-f031-4606-83e7-f093774a26b0"), Code="revokedBy", Description="Revoked By", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
