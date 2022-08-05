//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefProficiencyStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RefProficiencyStatu Model
     /// </summary>
    public partial class RefProficiencyStatu : ReferenceModelBase, IRefProficiencyStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefProficiencyStatus"/> model
        /// </summary>
        public Guid RefProficiencyStatusId { get; set; }

    }
}
