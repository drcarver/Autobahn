//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IRefELOtherFederalFundingSource.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The RefELOtherFederalFundingSource Interface
     /// </summary>
    public partial interface IRefELOtherFederalFundingSource : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefELOtherFederalFundingSources"/> model
        /// </summary>
        Guid RefELOtherFederalFundingSourcesId { get; set; }

    }
}
