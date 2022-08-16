//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialDefAgent.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialDefAgent Interface
     /// </summary>
    public partial interface ICredentialDefAgent : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCredentialDefAgentRoleTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefCTDLOrganizationTypeId { get; set; }

    }
}
