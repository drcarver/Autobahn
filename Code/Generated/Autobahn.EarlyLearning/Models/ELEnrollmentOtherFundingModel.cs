//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELEnrollmentOtherFundingModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELEnrollmentOtherFunding Model
     /// </summary>
    public partial class ELEnrollmentOtherFundingModel : AutobahnBase, Interfaces.IELEnrollmentOtherFundingModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefELOtherFederalFundingSources"/> model
        /// </summary>
        public Guid RefELOtherFederalFundingSourcesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
