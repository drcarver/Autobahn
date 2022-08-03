//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolCorrectiveAction.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SchoolCorrectiveAction
     /// </summary>
    public partial class K12SchoolCorrectiveAction : IK12SchoolCorrectiveAction
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12School"/> model
        /// </summary>
        public Guid K12SchoolId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefCorrectiveActionType"/> model
        /// </summary>
        public Guid RefCorrectiveActionTypeId { get; set; }

        /// <summary>
        /// Defines the K12SchoolCorrectiveAction.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12SchoolCorrectiveAction.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
