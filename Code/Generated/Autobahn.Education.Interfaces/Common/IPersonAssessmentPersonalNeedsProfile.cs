//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonAssessmentPersonalNeedsProfile.cs
//***************************************************************************

namespace Autobahn.Education.Interfaces.Common
{
     /// <summary>
     /// The IPersonAssessmentPersonalNeedsProfile Interface
     /// </summary>
    public partial interface IPersonAssessmentPersonalNeedsProfile : IAutobahnBase
    {
        #region IPersonAssessmentPersonalNeedsProfile
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
        /// </summary>
        Guid AssessmentPersonalNeedsProfileId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        #endregion
    }
}
