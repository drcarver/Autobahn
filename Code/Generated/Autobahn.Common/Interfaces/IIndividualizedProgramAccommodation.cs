//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramAccommodation.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramAccommodation
     /// </summary>
    public partial interface IIndividualizedProgramAccommodation : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramAccommodation.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramAccommodation.Applicability non nullable property
        /// </summary>
        System.String Applicability { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAccommodationType"/> model
        /// </summary>
        Guid? RefAccommodationTypeId { get; set; }

    }
}
