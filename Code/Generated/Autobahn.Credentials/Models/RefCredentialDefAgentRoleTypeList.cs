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
        public static List<RefCredentialDefAgentRoleType> RefCredentialDefAgentRoleTypeList = new List<RefCredentialDefAgentRoleType> =
        {
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("56d6c64f-f5da-449e-a280-77b5c0a83622"), Code="Quality assurance organization that provides official authorization to, or approval of, a credential, organization, assessment, or learning opportunity.", Description="accreditedBy", Definition="", SortOrder=0 },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("18bf42c5-a386-469c-b595-75c80ffea420"), Code="Organization that pronounces favorable judgment for this credential, assessment, learning opportunity, or organization.", Description="approvedBy", Definition="", SortOrder=0 },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("91fb5e39-39c6-43fe-beaa-4bc1dd1dd35d"), Code="Agent that offers the resource.", Description="offeredBy", Definition="", SortOrder=0 },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("646f0817-c63a-4fa4-8ca1-617e37c756aa"), Code="Organization or person with an enforceable claim or legal title to the Credential Definition resource.", Description="ownedBy", Definition="", SortOrder=0 },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("873e59b9-afb4-4abf-a634-0bdbb667f1a8"), Code="Agent that acknowledges the validity of the credential, learning opportunity, or assessment.", Description="recognizedBy", Definition="", SortOrder=0 },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("368f01eb-40a8-4931-ab8a-faa8a354c369"), Code="Quality assurance organization that enforces the legal requirements of the credential, learning resource, or assessment.", Description="regulatedBy", Definition="", SortOrder=0 },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("b694c37e-80b1-4004-b78a-e03db15087b3"), Code="Organization or person that handles the renewal of the credential.", Description="renewedBy", Definition="", SortOrder=0 },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("ecee611e-e340-4f2b-8180-e5e3e9d3f260"), Code="Organization or person that handles revocation of an awarded credential due to violations or failure to renew.", Description="revokedBy", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCredentialDefAgentRoleType Pick List
         /// </summary>
        public static List<RefCredentialDefAgentRoleType> RefCredentialDefAgentRoleTypePickList = new List<RefCredentialDefAgentRoleType> =
        {
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("56d6c64f-f5da-449e-a280-77b5c0a83622"), Code="Quality assurance organization that provides official authorization to, or approval of, a credential, organization, assessment, or learning opportunity.", SortOrder=0 },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("18bf42c5-a386-469c-b595-75c80ffea420"), Code="Organization that pronounces favorable judgment for this credential, assessment, learning opportunity, or organization.", SortOrder=0 },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("91fb5e39-39c6-43fe-beaa-4bc1dd1dd35d"), Code="Agent that offers the resource.", SortOrder=0 },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("646f0817-c63a-4fa4-8ca1-617e37c756aa"), Code="Organization or person with an enforceable claim or legal title to the Credential Definition resource.", SortOrder=0 },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("873e59b9-afb4-4abf-a634-0bdbb667f1a8"), Code="Agent that acknowledges the validity of the credential, learning opportunity, or assessment.", SortOrder=0 },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("368f01eb-40a8-4931-ab8a-faa8a354c369"), Code="Quality assurance organization that enforces the legal requirements of the credential, learning resource, or assessment.", SortOrder=0 },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("b694c37e-80b1-4004-b78a-e03db15087b3"), Code="Organization or person that handles the renewal of the credential.", SortOrder=0 },
            new RefCredentialDefAgentRoleType { Id=Guid.Parse("ecee611e-e340-4f2b-8180-e5e3e9d3f260"), Code="Organization or person that handles revocation of an awarded credential due to violations or failure to renew.", SortOrder=0 },
       };
   }
}
