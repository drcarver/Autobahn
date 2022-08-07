//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPerson_AssessmentPersonalNeedsProfileModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPerson_AssessmentPersonalNeedsProfileModel Interface
     /// </summary>
    public partial interface IPerson_AssessmentPersonalNeedsProfileModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfile"/> model
        /// </summary>
        Guid AssessmentPersonalNeedsProfileId { get; set; }

    }
}
