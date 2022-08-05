//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefEDFactsTeacherInexperiencedStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefEDFactsTeacherInexperiencedStatu Model
     /// </summary>
    public partial class RefEDFactsTeacherInexperiencedStatu : ReferenceModelBase, IRefEDFactsTeacherInexperiencedStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefEDFactsTeacherInexperiencedStatus"/> model
        /// </summary>
        public Guid RefEDFactsTeacherInexperiencedStatusId { get; set; }

    }
}
