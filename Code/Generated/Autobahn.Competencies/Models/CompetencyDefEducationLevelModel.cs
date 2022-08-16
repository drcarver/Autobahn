//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefEducationLevelModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencyDefEducationLevel Model
     /// </summary>
    public partial class CompetencyDefEducationLevelModel : AutobahnBase, Interfaces.ICompetencyDefEducationLevel
    {
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
        public Guid? RefEducationLevelId { get; set; }

    }
}
