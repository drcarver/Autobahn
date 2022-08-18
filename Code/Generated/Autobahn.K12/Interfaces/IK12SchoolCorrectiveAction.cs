//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12SchoolCorrectiveAction.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SchoolCorrectiveAction Interface
     /// </summary>
    public partial interface IK12SchoolCorrectiveAction : IAutobahnBase
    {
        /// <summary>
        /// Accreditation Agency Name
        /// <para>
        /// The full name of an agency that accredited a school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20500">Accreditation Agency Name</a>
        /// </para>
        /// </summary>
        Guid K12SchoolId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCorrectiveActionType"/> model
        /// </summary>
        Guid RefCorrectiveActionTypeId { get; set; }

    }
}
