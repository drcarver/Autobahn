//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PDActivityEducationLevel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PDActivityEducationLevel
     /// </summary>
    public partial class PDActivityEducationLevel : IPDActivityEducationLevel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentActivity"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPDActivityEducationLevelsAddressed"/> model
        /// </summary>
        public Guid RefPDActivityEducationLevelsAddressedId { get; set; }

        /// <summary>
        /// Defines the PDActivityEducationLevel.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PDActivityEducationLevel.RecordEndDateTime nullable property
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
