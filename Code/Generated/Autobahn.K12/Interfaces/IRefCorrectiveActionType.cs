//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefCorrectiveActionType.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefCorrectiveActionType Interface
     /// </summary>
    public partial interface IRefCorrectiveActionType : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefCorrectiveAction"/> model
        /// </summary>
        Guid RefCorrectiveActionId { get; set; }

    }
}
