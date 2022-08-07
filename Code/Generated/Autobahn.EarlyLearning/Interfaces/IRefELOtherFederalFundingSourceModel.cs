//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IRefELOtherFederalFundingSourceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The RefELOtherFederalFundingSource Interface Model
     /// </summary>
    public partial interface IRefELOtherFederalFundingSourceModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefELOtherFederalFundingSources"/> model
        /// </summary>
        Guid RefELOtherFederalFundingSourcesId { get; set; }

    }
}
