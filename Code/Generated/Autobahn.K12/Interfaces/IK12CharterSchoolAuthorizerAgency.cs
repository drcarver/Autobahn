//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12CharterSchoolAuthorizerAgency.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12CharterSchoolAuthorizerAgency Interface
     /// </summary>
    public partial interface IK12CharterSchoolAuthorizerAgency : IAutobahnBase
    {
        /// <summary>
        /// The type of agency that authorized the establishment or continuation of a charter school.
        /// </summary>
        Guid? OrganizationId { get; set; }

        /// <summary>
        /// The type of agency that authorized the establishment or continuation of a charter school.
        /// </summary>
        Guid RefCharterSchoolAuthorizerTypeId { get; set; }

    }
}
