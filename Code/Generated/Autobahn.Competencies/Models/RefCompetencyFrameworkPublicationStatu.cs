//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   RefCompetencyFrameworkPublicationStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Competencies.Interfaces;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The RefCompetencyFrameworkPublicationStatu Model
     /// </summary>
    public partial class RefCompetencyFrameworkPublicationStatu : ReferenceModelBase, IRefCompetencyFrameworkPublicationStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefCompetencyFrameworkPublicationStatus"/> model
        /// </summary>
        public Guid RefCompetencyFrameworkPublicationStatusId { get; set; }

    }
}
