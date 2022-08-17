//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PSStudentEnrollmentModel.cs
//* Name:       Displaced Student Status
//* Definition: A student who was enrolled, or eligible for enrollment, but has enrolled in another place because of a crisis.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// A student who was enrolled, or eligible for enrollment, but has enrolled in another place because of a crisis.
     /// </summary>
    public partial class PSStudentEnrollmentModel : AutobahnBase, Interfaces.IPSStudentEnrollment
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
        public  DisplacedStudentStatus { get; set; }

    }
}
