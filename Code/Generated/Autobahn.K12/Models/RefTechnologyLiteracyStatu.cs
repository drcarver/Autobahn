//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefTechnologyLiteracyStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefTechnologyLiteracyStatu Model
     /// </summary>
    public partial class RefTechnologyLiteracyStatu : ReferenceModelBase, IRefTechnologyLiteracyStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTechnologyLiteracyStatus"/> model
        /// </summary>
        public Guid RefTechnologyLiteracyStatusId { get; set; }

    }
}
