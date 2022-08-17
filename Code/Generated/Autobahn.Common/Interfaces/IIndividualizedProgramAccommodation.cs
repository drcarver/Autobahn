//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramAccommodation.cs
//* Name:       Individualized Program Accommodation Applicability
//* Definition: 
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IIndividualizedProgramAccommodation : IAutobahnBase
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
        System.String Applicability { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAccommodationType"/> model
        /// </summary>
        Guid? RefAccommodationTypeId { get; set; }

    }
}
