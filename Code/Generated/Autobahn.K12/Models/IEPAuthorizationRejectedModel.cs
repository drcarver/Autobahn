//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IEPAuthorizationRejectedModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The IEPAuthorizationRejected Model
     /// </summary>
    public partial class IEPAuthorizationRejectedModel : AutobahnBase, Interfaces.IIEPAuthorizationRejected
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IIEPAuthorization"/> model
        /// </summary>
        public Guid IEPAuthorizationId { get; set; }

        /// <summary>
        /// IEP Authorization Rejected Portion Description
        /// <para>
        /// Portion the authorizer does not want executed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20704">IEP Authorization Rejected Portion Description</a>
        /// </para>
        /// </summary>
        public System.String PortionDescription { get; set; }

        /// <summary>
        /// IEP Authorization Rejected Portion Explanation
        /// <para>
        /// Authorizer's explanation for rejected portions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20705">IEP Authorization Rejected Portion Explanation</a>
        /// </para>
        /// </summary>
        public System.String PortionExplanation { get; set; }

    }
}
