//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefinitionCompetencySetModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencyDefinitionCompetencySet Model
     /// </summary>
    public partial class CompetencyDefinitionCompetencySetModel : AutobahnBase, Interfaces.ICompetencyDefinitionCompetencySet
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

    }
}
