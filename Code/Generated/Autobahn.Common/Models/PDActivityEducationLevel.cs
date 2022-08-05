//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PDActivityEducationLevel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PDActivityEducationLevel
     /// </summary>
    public partial class PDActivityEducationLevel : AutobahnBase, Interfaces.IPDActivityEducationLevel
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
