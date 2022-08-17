//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IIEPAuthorizationRejected.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IIEPAuthorizationRejected Interface
     /// </summary>
    public partial interface IIEPAuthorizationRejected : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IIEPAuthorization"/> model
        /// </summary>
        Guid IEPAuthorizationId { get; set; }

        /// <summary>
        /// IEP Authorization Rejected Portion Description
        /// <para>
        /// Portion the authorizer does not want executed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20704">IEP Authorization Rejected Portion Description</a>
        /// </para>
        /// </summary>
        System.String PortionDescription { get; set; }

        /// <summary>
        /// IEP Authorization Rejected Portion Explanation
        /// <para>
        /// Authorizer's explanation for rejected portions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20705">IEP Authorization Rejected Portion Explanation</a>
        /// </para>
        /// </summary>
        System.String PortionExplanation { get; set; }

    }
}
