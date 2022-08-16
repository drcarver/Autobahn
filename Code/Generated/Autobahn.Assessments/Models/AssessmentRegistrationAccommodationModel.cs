//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentRegistrationAccommodationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentRegistrationAccommodation Model
     /// </summary>
    public partial class AssessmentRegistrationAccommodationModel : AutobahnBase, Interfaces.IAssessmentRegistrationAccommodation
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
