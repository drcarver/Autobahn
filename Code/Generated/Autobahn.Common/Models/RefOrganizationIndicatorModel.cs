//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefOrganizationIndicatorModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefOrganizationIndicator Model
     /// </summary>
    public partial class RefOrganizationIndicatorModel : ReferenceModelBase, IRefOrganizationIndicatorModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationType"/> model
        /// </summary>
        public Guid? RefOrganizationTypeId { get; set; }

    }
}
