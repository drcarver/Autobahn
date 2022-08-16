//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentParticipantSessionAccommodationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentParticipantSessionAccommodation Model
     /// </summary>
    public partial class AssessmentParticipantSessionAccommodationModel : AutobahnBase, Interfaces.IAssessmentParticipantSessionAccommodation
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
