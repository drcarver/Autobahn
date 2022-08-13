//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELEnrollmentOtherFundingModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELEnrollmentOtherFunding Model
     /// </summary>
    public partial class ELEnrollmentOtherFundingModel : AutobahnBase, Interfaces.IELEnrollmentOtherFunding
    {
        /// <summary>
        /// The other contributing funding sources.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// The other contributing funding sources.
        /// </summary>
        public Guid RefELOtherFederalFundingSourcesId { get; set; }

    }
}
