//**********************************************************
//* DomainName: Autobahn.CareerandTechnical
//* FileName:   IProgram.cs
//**********************************************************

namespace Autobahn.CareerandTechnical.Interfaces
{
     /// <summary>
     /// The IProgram
     /// </summary>
    public partial interface IProgram
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Program"/> model
        /// </summary>
        Guid ProgramId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the Program.CreditsRequired nullable property
        /// </summary>
        System.Decimal? CreditsRequired { get; set; }

        /// <summary>
        /// Defines the Program.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the Program.RecordEndDateTime nullable property
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
