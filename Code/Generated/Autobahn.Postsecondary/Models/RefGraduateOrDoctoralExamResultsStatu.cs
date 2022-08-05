//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefGraduateOrDoctoralExamResultsStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefGraduateOrDoctoralExamResultsStatu Model
     /// </summary>
    public partial class RefGraduateOrDoctoralExamResultsStatu : ReferenceModelBase, IRefGraduateOrDoctoralExamResultsStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefGraduateOrDoctoralExamResultsStatus"/> model
        /// </summary>
        public Guid RefGraduateOrDoctoralExamResultsStatusId { get; set; }

    }
}
