//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetRubricModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencySetRubric Model
     /// </summary>
    public partial class CompetencySetRubricModel : AutobahnBase, Interfaces.ICompetencySetRubric
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
