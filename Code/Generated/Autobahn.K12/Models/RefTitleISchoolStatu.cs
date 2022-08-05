//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefTitleISchoolStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefTitleISchoolStatu Model
     /// </summary>
    public partial class RefTitleISchoolStatu : ReferenceModelBase, IRefTitleISchoolStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTitleISchoolStatus"/> model
        /// </summary>
        public Guid RefTitleISchoolStatusId { get; set; }

    }
}
