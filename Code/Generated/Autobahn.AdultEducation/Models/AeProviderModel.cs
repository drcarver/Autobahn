//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeProviderModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The AeProvider Model
     /// </summary>
    public partial class AeProviderModel : AutobahnBase, Interfaces.IAeProvider
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLevelOfInstitution"/> model
        /// </summary>
        public Guid RefLevelOfInstitutionId { get; set; }

    }
}
