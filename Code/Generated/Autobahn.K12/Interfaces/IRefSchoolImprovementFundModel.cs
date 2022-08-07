//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefSchoolImprovementFundModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefSchoolImprovementFund Interface Model
     /// </summary>
    public partial interface IRefSchoolImprovementFundModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefSchoolImprovementFunds"/> model
        /// </summary>
        Guid RefSchoolImprovementFundsId { get; set; }

    }
}
