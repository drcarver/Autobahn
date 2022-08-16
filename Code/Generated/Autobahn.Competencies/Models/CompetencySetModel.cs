//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencySet Model
     /// </summary>
    public partial class CompetencySetModel : AutobahnBase, Interfaces.ICompetencySet
    {
        /// <summary>
        /// 
        /// </summary>
        public  CompletionCriteriaThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefCompletionCriteriaId { get; set; }

    }
}
