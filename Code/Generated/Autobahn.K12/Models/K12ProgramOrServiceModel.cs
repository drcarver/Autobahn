//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12ProgramOrServiceModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12ProgramOrService Model
     /// </summary>
    public partial class K12ProgramOrServiceModel : AutobahnBase, Interfaces.IK12ProgramOrService
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Program in Multiple Purpose Facility
        /// <para>
        /// An institution/facility/program that serves more than one programming purpose.  For example, the same facility may run both a juvenile correction program and a juvenile detention program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19476">Program in Multiple Purpose Facility</a>
        /// </para>
        /// </summary>
        public System.Boolean? ProgramInMultiplePurposeFacility { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefKindergartenDailyLength"/> model
        /// </summary>
        public Guid? RefKindergartenDailyLengthId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepProjectType"/> model
        /// </summary>
        public Guid? RefMepProjectTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepSessionType"/> model
        /// </summary>
        public Guid? RefMepSessionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrekindergartenDailyLength"/> model
        /// </summary>
        public Guid? RefPrekindergartenDailyLengthId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramGiftedEligibility"/> model
        /// </summary>
        public Guid? RefProgramGiftedEligibilityId { get; set; }

        /// <summary>
        /// Title I Instructional Services
        /// <para>
        /// The type of instructional services provided to students in ESEA Title I programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19282">Title I Instructional Services</a>
        /// </para>
        /// </summary>
        public Guid? RefTitleIInstructionalServicesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIProgramType"/> model
        /// </summary>
        public Guid? RefTitleIProgramTypeId { get; set; }

    }
}
