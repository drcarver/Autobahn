//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPerson_AssessmentPersonalNeedsProfile.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPerson_AssessmentPersonalNeedsProfile
     /// </summary>
    public partial interface IPerson_AssessmentPersonalNeedsProfile : IAutobahnBase
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
