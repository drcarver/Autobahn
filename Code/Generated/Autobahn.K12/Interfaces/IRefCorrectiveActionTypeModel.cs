//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefCorrectiveActionTypeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefCorrectiveActionType Interface Model
     /// </summary>
    public partial interface IRefCorrectiveActionTypeModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefCorrectiveAction"/> model
        /// </summary>
        Guid RefCorrectiveActionId { get; set; }

    }
}
