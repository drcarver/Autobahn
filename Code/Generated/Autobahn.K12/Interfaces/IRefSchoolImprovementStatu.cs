//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefSchoolImprovementStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefSchoolImprovementStatu Interface
     /// </summary>
    public partial interface IRefSchoolImprovementStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefSchoolImprovementStatus"/> model
        /// </summary>
        Guid RefSchoolImprovementStatusId { get; set; }

    }
}
