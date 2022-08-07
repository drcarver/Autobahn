//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentLevelsForWhichDesignedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentLevelsForWhichDesigned Model
     /// </summary>
    public partial class AssessmentLevelsForWhichDesignedModel : AutobahnBase, Interfaces.IAssessmentLevelsForWhichDesignedModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Assessment"/> model
        /// </summary>
        public Guid AssessmentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefGradeLevel"/> model
        /// </summary>
        public Guid RefGradeLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
