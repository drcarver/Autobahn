//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetRubricCriterionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencySetRubricCriterion Model
     /// </summary>
    public partial class CompetencySetRubricCriterionModel : AutobahnBase, Interfaces.ICompetencySetRubricCriterion
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
