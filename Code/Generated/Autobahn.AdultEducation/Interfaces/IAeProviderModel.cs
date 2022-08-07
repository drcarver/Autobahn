//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   IAeProviderModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The IAeProviderModel Interface
     /// </summary>
    public partial interface IAeProviderModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefLevelOfInstitution"/> model
        /// </summary>
        Guid RefLevelOfInstitutionId { get; set; }

    }
}
