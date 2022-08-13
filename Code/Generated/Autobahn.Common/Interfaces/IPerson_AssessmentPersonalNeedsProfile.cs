//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPerson_AssessmentPersonalNeedsProfile.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPerson_AssessmentPersonalNeedsProfile Interface
     /// </summary>
    public partial interface IPerson_AssessmentPersonalNeedsProfile : IAutobahnBase
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        Guid AssessmentPersonalNeedsProfileId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        Guid PersonId { get; set; }

    }
}
