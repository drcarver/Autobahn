//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationEmployeeBenefit.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationEmployeeBenefit
     /// </summary>
    public partial interface IOrganizationEmployeeBenefit : IAutobahnBase
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

    }
}
