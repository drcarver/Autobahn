//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefTimeForCompletionUnit.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefTimeForCompletionUnit Model
     /// </summary>
    public partial class RefTimeForCompletionUnit : ReferenceModelBase, IRefTimeForCompletionUnit
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTimeForCompletionUnits"/> model
        /// </summary>
        public Guid RefTimeForCompletionUnitsId { get; set; }

    }
}
