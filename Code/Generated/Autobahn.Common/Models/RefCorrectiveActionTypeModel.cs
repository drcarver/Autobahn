//**********************************************************
//* DomainName: Common Models
//* FileName:   RefCorrectiveActionTypeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefCorrectiveActionType Model
     /// </summary>
    public partial class RefCorrectiveActionType : ReferenceModelBase, Interfaces.IRefCorrectiveActionType
    {
        /// <summary>
        /// The types of corrective actions under ESEA as amended.
        /// </summary>
        public Guid RefCorrectiveActionId { get; set; }

    }
}
