//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELEnrollmentOtherFundingModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELEnrollmentOtherFundingModel Interface
     /// </summary>
    public partial interface IELEnrollmentOtherFundingModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefELOtherFederalFundingSources"/> model
        /// </summary>
        Guid RefELOtherFederalFundingSourcesId { get; set; }

    }
}
