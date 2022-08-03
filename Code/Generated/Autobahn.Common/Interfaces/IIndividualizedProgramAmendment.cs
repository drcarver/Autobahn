//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramAmendment.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramAmendment
     /// </summary>
    public partial interface IIndividualizedProgramAmendment
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

        /// <summary>
        /// Defines the IndividualizedProgramAmendment.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramAmendment.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
