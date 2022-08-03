//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationEmployeeBenefit.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationEmployeeBenefit
     /// </summary>
    public partial interface IOrganizationEmployeeBenefit
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationEmployeeBenefit.FullTimeBenefitIndicator nullable property
        /// </summary>
        System.Boolean? FullTimeBenefitIndicator { get; set; }

        /// <summary>
        /// Defines the OrganizationEmployeeBenefit.PartTimeBenefitIndicator nullable property
        /// </summary>
        System.Boolean? PartTimeBenefitIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployeeBenefit"/> model
        /// </summary>
        Guid? RefEmployeeBenefitId { get; set; }

        /// <summary>
        /// Defines the OrganizationEmployeeBenefit.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationEmployeeBenefit.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
