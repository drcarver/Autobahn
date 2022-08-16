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
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPersonalInformationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefPersonalInformationVerificationId { get; set; }

    }
}
