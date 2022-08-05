//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationEmployeeBenefit.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationEmployeeBenefit
     /// </summary>
    public partial class OrganizationEmployeeBenefit : AutobahnBase, Interfaces.IOrganizationEmployeeBenefit
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
