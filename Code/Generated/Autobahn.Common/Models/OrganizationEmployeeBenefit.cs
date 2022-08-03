//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationEmployeeBenefit.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationEmployeeBenefit
     /// </summary>
    public partial class OrganizationEmployeeBenefit : IOrganizationEmployeeBenefit
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationEmployeeBenefit.FullTimeBenefitIndicator nullable property
        /// </summary>
        public System.Boolean? FullTimeBenefitIndicator { get; set; }

        /// <summary>
        /// Defines the OrganizationEmployeeBenefit.PartTimeBenefitIndicator nullable property
        /// </summary>
        public System.Boolean? PartTimeBenefitIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployeeBenefit"/> model
        /// </summary>
        public Guid? RefEmployeeBenefitId { get; set; }

        /// <summary>
        /// Defines the OrganizationEmployeeBenefit.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationEmployeeBenefit.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
