//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonPersonalInformationVerification.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonPersonalInformationVerification Interface
     /// </summary>
    public partial interface IPersonPersonalInformationVerification : IAutobahnBase
    {
        /// <summary>
        /// The evidence by which a persons name, address, date of birth, etc. is confirmed.
        /// </summary>
        Guid? RefPersonalInformationVerificationId { get; set; }

    }
}
