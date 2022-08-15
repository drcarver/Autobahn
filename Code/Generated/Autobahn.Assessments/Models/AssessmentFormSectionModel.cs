//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentFormSection Model
     /// </summary>
    public partial class AssessmentFormSectionModel : AutobahnBase, Interfaces.IAssessmentFormSection
    {
        /// <summary>
        /// The globally unique identifier of an Assessment using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public System.String GUID { get; set; }

    }
}
