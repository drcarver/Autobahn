//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELEnrollmentOtherFunding.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELEnrollmentOtherFunding Interface
     /// </summary>
    public partial interface IELEnrollmentOtherFunding : IAutobahnBase
    {
        /// <summary>
        /// The other contributing funding sources.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// The other contributing funding sources.
        /// </summary>
        Guid RefELOtherFederalFundingSourcesId { get; set; }

    }
}
