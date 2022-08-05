//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefELOtherFederalFundingSource.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.EarlyLearning.Interfaces;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The RefELOtherFederalFundingSource Model
     /// </summary>
    public partial class RefELOtherFederalFundingSource : ReferenceModelBase, IRefELOtherFederalFundingSource
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefELOtherFederalFundingSources"/> model
        /// </summary>
        public Guid RefELOtherFederalFundingSourcesId { get; set; }

    }
}
