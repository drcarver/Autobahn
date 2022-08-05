//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELEnrollmentOtherFunding.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELEnrollmentOtherFunding
     /// </summary>
    public partial class ELEnrollmentOtherFunding : AutobahnBase, Interfaces.IELEnrollmentOtherFunding
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
