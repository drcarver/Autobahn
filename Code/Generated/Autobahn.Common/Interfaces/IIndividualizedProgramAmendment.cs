//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramAmendment.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramAmendment
     /// </summary>
    public partial interface IIndividualizedProgramAmendment : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramAmendment.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramAmendment.ReasonDescription non nullable property
        /// </summary>
        System.String ReasonDescription { get; set; }

    }
}
