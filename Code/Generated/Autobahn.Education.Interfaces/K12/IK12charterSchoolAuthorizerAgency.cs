//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12charterSchoolAuthorizerAgency.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.K12
{
     /// <summary>
     /// The IK12charterSchoolAuthorizerAgency Interface
     /// </summary>
    public partial interface IK12charterSchoolAuthorizerAgency : IAutobahnBase
    {
        #region IK12charterSchoolAuthorizerAgency
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCharterSchoolAuthorizerType"/> model
        /// </summary>
        Guid RefCharterSchoolAuthorizerTypeId { get; set; }

        #endregion
    }
}
