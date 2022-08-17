//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12ProgramOrService.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12ProgramOrService Interface
     /// </summary>
    public partial interface IK12ProgramOrService : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Program in Multiple Purpose Facility
        /// <para>
        /// An institution/facility/program that serves more than one programming purpose.  For example, the same facility may run both a juvenile correction program and a juvenile detention program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19476">Program in Multiple Purpose Facility</a>
        /// </para>
        /// </summary>
        System.Boolean? ProgramInMultiplePurposeFacility { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefKindergartenDailyLength"/> model
        /// </summary>
        Guid? RefKindergartenDailyLengthId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefMepProjectType"/> model
        /// </summary>
        Guid? RefMepProjectTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefMepSessionType"/> model
        /// </summary>
        Guid? RefMepSessionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefPrekindergartenDailyLength"/> model
        /// </summary>
        Guid? RefPrekindergartenDailyLengthId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefProgramGiftedEligibility"/> model
        /// </summary>
        Guid? RefProgramGiftedEligibilityId { get; set; }

        /// <summary>
        /// Title I Instructional Services
        /// <para>
        /// The type of instructional services provided to students in ESEA Title I programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19282">Title I Instructional Services</a>
        /// </para>
        /// </summary>
        Guid? RefTitleIInstructionalServicesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefTitleIProgramType"/> model
        /// </summary>
        Guid? RefTitleIProgramTypeId { get; set; }

    }
}
