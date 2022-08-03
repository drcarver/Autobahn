//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   FinancialAidApplication.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The FinancialAidApplication
     /// </summary>
    public partial class FinancialAidApplication : IFinancialAidApplication
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefFinancialAidApplicationType"/> model
        /// </summary>
        public Guid RefFinancialAidApplicationTypeId { get; set; }

        /// <summary>
        /// Defines the FinancialAidApplication.FinancialAidYearDesignator non nullable property
        /// </summary>
        public System.String FinancialAidYearDesignator { get; set; }

        /// <summary>
        /// Defines the FinancialAidApplication.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FinancialAidApplication.RecordEndDateTime nullable property
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
