//**********************************************************
//* DomainName: Common Models
//* FileName:   Person_AssessmentPersonalNeedsProfileModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Person_AssessmentPersonalNeedsProfile Model
     /// </summary>
    public partial class Person_AssessmentPersonalNeedsProfileModel : AutobahnBase, Interfaces.IPerson_AssessmentPersonalNeedsProfile
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
