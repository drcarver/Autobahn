//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12sea.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.K12
{
     /// <summary>
     /// The IK12sea Interface
     /// </summary>
    public partial interface IK12sea : IAutobahnBase
    {
        #region IK12sea
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStateAnsicode"/> model
        /// </summary>
        Guid? RefStateAnsicodeId { get; set; }

        #endregion
    }
}
