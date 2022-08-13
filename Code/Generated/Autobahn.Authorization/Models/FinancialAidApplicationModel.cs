//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   FinancialAidApplicationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The FinancialAidApplication Model
     /// </summary>
    public partial class FinancialAidApplicationModel : AutobahnBase, Interfaces.IFinancialAidApplication
    {
        /// <summary>
        /// The type of financial application completed by an individual.
        /// </summary>
        public System.String FinancialAidYearDesignator { get; set; }

        /// <summary>
        /// The type of financial application completed by an individual.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The type of financial application completed by an individual.
        /// </summary>
        public Guid RefFinancialAidApplicationTypeId { get; set; }

    }
}
