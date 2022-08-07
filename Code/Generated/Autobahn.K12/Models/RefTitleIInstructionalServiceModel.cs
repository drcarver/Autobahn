//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefTitleIInstructionalServiceModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefTitleIInstructionalService Model
     /// </summary>
    public partial class RefTitleIInstructionalServiceModel : ReferenceModelBase, IRefTitleIInstructionalServiceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTitleIInstructionalServices"/> model
        /// </summary>
        public Guid RefTitleIInstructionalServicesId { get; set; }

    }
}
