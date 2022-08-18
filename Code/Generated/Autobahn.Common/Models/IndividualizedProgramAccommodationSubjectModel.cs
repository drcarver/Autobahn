//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramAccommodationSubjectModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramAccommodationSubject Model
     /// </summary>
    public partial class IndividualizedProgramAccommodationSubjectModel : AutobahnBase, Interfaces.IIndividualizedProgramAccommodationSubject
    {
        /// <summary>
        /// Individualized Program Accommodation Applicability
        /// <para>
        /// Circumstances in which the accommodation or change to standards or practices will be applied.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20667">Individualized Program Accommodation Applicability</a>
        /// </para>
        /// </summary>
        public Guid IndividualizedProgramAccommodationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSCEDCourseSubjectArea"/> model
        /// </summary>
        public Guid RefSCEDCourseSubjectAreaId { get; set; }

    }
}
