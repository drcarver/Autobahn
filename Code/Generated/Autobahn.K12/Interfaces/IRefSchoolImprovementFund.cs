//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefSchoolImprovementFund.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefSchoolImprovementFund Interface
     /// </summary>
    public partial interface IRefSchoolImprovementFund : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefSchoolImprovementFunds"/> model
        /// </summary>
        Guid RefSchoolImprovementFundsId { get; set; }

    }
}
