//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   AeProvider.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The AeProvider
     /// </summary>
    public partial class AeProvider : AutobahnBase, Interfaces.IAeProvider
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefLevelOfInstitution"/> model
        /// </summary>
        public Guid RefLevelOfInstitutionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
