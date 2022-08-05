//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12CharterSchoolAuthorizerAgency.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12CharterSchoolAuthorizerAgency
     /// </summary>
    public partial interface IK12CharterSchoolAuthorizerAgency : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefCharterSchoolAuthorizerType"/> model
        /// </summary>
        Guid RefCharterSchoolAuthorizerTypeId { get; set; }

    }
}
