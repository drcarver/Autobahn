//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAssessmentPersonalNeedsProfileModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonAssessmentPersonalNeedsProfile Model
     /// </summary>
    public partial class PersonAssessmentPersonalNeedsProfileModel : AutobahnBase, Interfaces.IPersonAssessmentPersonalNeedsProfile
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid PersonId { get; set; }

    }
}
