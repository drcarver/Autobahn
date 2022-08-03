//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IFinancialAidApplication.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IFinancialAidApplication
     /// </summary>
    public partial interface IFinancialAidApplication
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefFinancialAidApplicationType"/> model
        /// </summary>
        Guid RefFinancialAidApplicationTypeId { get; set; }

        /// <summary>
        /// Defines the FinancialAidApplication.FinancialAidYearDesignator non nullable property
        /// </summary>
        System.String FinancialAidYearDesignator { get; set; }

        /// <summary>
        /// Defines the FinancialAidApplication.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FinancialAidApplication.RecordEndDateTime nullable property
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
