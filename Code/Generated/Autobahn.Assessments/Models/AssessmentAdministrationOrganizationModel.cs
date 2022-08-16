//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAdministrationOrganizationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentAdministrationOrganization Model
     /// </summary>
    public partial class AssessmentAdministrationOrganizationModel : AutobahnBase, Interfaces.IAssessmentAdministrationOrganization
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
