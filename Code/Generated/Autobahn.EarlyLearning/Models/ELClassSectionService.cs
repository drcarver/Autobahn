//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELClassSectionService.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELClassSectionService
     /// </summary>
    public partial class ELClassSectionService : AutobahnBase, Interfaces.IELClassSectionService
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ELClassSection"/> model
        /// </summary>
        public Guid ELClassSectionId { get; set; }

        /// <summary>
        /// Defines the ELClassSectionService.YoungestAgeServed nullable property
        /// </summary>
        public System.Int32? YoungestAgeServed { get; set; }

        /// <summary>
        /// Defines the ELClassSectionService.OldestAgeServed nullable property
        /// </summary>
        public System.Int32? OldestAgeServed { get; set; }

        /// <summary>
        /// Defines the ELClassSectionService.ServesChildrenWithSpecialNeeds nullable property
        /// </summary>
        public System.Boolean? ServesChildrenWithSpecialNeeds { get; set; }

        /// <summary>
        /// Defines the ELClassSectionService.ELClassGroupCurriculumType non nullable property
        /// </summary>
        public System.String ELClassGroupCurriculumType { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELGroupSizeStandardMet"/> model
        /// </summary>
        public Guid? RefELGroupSizeStandardMetId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFrequencyOfService"/> model
        /// </summary>
        public Guid? RefFrequencyOfServiceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
