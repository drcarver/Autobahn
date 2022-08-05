//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefPublicSchoolChoiceStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefPublicSchoolChoiceStatu Model
     /// </summary>
    public partial class RefPublicSchoolChoiceStatu : ReferenceModelBase, IRefPublicSchoolChoiceStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefPublicSchoolChoiceStatus"/> model
        /// </summary>
        public Guid RefPublicSchoolChoiceStatusId { get; set; }

    }
}
