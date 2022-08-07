//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefCorrectiveActionTypeModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefCorrectiveActionType Model
     /// </summary>
    public partial class RefCorrectiveActionTypeModel : ReferenceModelBase, IRefCorrectiveActionTypeModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefCorrectiveAction"/> model
        /// </summary>
        public Guid RefCorrectiveActionId { get; set; }

    }
}
