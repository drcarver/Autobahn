//**********************************************************
//* DomainName: Common Models
//* FileName:   IRefCorrectiveActionType.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefCorrectiveActionType Interface Model
     /// </summary>
    public partial interface IRefCorrectiveActionType : IReferenceModel
    {
        /// <summary>
        /// The types of corrective actions under ESEA as amended.
        /// </summary>
        Guid RefCorrectiveActionId { get; set; }

    }
}
