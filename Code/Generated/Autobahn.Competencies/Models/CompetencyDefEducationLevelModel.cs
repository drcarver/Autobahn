//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefEducationLevelModel.cs
//***************************************************************************

using Autobahn.Interfaces.Competencies;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencyDefEducationLevel Model
     /// </summary>
    public partial class CompetencyDefEducationLevelModel : AutobahnBase, ICompetencyDefEducationLevel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
        /// </summary>
        public Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// Competency Definition Education Level
        /// <para>
        /// The education level, grade level or primary instructional level at which a Competency Definition is intended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19701">Competency Definition Education Level</a>
        /// </para>
        /// </summary>
        public Guid RefEducationLevelId { get; set; }

    }
}
