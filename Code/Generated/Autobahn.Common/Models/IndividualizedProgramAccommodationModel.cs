//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramAccommodationModel.cs
//* Name:       Individualized Program Accommodation Applicability
//* Definition: Circumstances in which the accommodation or change to standards or practices will be applied.
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// Circumstances in which the accommodation or change to standards or practices will be applied.
     /// </summary>
    public partial class IndividualizedProgramAccommodationModel : AutobahnBase, Interfaces.IIndividualizedProgramAccommodation
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
        public System.String Applicability { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAccommodationType"/> model
        /// </summary>
        public Guid? RefAccommodationTypeId { get; set; }

    }
}
