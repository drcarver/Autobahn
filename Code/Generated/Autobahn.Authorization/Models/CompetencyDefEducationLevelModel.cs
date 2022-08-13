//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   CompetencyDefEducationLevelModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The CompetencyDefEducationLevel Model
     /// </summary>
    public partial class CompetencyDefEducationLevelModel : AutobahnBase, Interfaces.ICompetencyDefEducationLevel
    {
        /// <summary>
        /// The education level, grade level or primary instructional level at which a Competency Definition is intended.
        /// </summary>
        public Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// The education level, grade level or primary instructional level at which a Competency Definition is intended.
        /// </summary>
        public Guid RefEducationLevelId { get; set; }

    }
}
