//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   CompetencyDefinition_CompetencySetModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The CompetencyDefinition_CompetencySet Model
     /// </summary>
    public partial class CompetencyDefinition_CompetencySetModel : AutobahnBase, Interfaces.ICompetencyDefinition_CompetencySet
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid CompetencySetId { get; set; }

    }
}
