//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramAmendment.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramAmendment
     /// </summary>
    public partial class IndividualizedProgramAmendment : AutobahnBase, Interfaces.IIndividualizedProgramAmendment
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramAmendment.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramAmendment.ReasonDescription non nullable property
        /// </summary>
        public System.String ReasonDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
