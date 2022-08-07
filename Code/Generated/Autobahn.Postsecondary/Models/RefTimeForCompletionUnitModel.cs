//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefTimeForCompletionUnitModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefTimeForCompletionUnit Model
     /// </summary>
    public partial class RefTimeForCompletionUnitModel : ReferenceModelBase, IRefTimeForCompletionUnitModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTimeForCompletionUnits"/> model
        /// </summary>
        public Guid RefTimeForCompletionUnitsId { get; set; }

    }
}
