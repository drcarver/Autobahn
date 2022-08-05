//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   FinancialAidApplication.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The FinancialAidApplication
     /// </summary>
    public partial class FinancialAidApplication : AutobahnBase, Interfaces.IFinancialAidApplication
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
