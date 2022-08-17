//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPSStudentEnrollment.cs
//* Name:       Displaced Student Status
//* Definition: 
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IPSStudentEnrollment : IAutobahnBase
    {
        /// <summary>
        /// Displaced Student Status
        /// <para>
        /// A student who was enrolled, or eligible for enrollment, but has enrolled in another place because of a crisis.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19603">Displaced Student Status</a>
        /// </para>
        /// </summary>
         DisplacedStudentStatus { get; set; }

    }
}
