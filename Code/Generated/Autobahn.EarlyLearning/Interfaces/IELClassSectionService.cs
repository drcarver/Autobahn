//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELClassSectionService.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELClassSectionService
     /// </summary>
    public partial interface IELClassSectionService : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ELClassSection"/> model
        /// </summary>
        Guid ELClassSectionId { get; set; }

        /// <summary>
        /// Defines the ELClassSectionService.YoungestAgeServed nullable property
        /// </summary>
        System.Int32? YoungestAgeServed { get; set; }

        /// <summary>
        /// Defines the ELClassSectionService.OldestAgeServed nullable property
        /// </summary>
        System.Int32? OldestAgeServed { get; set; }

        /// <summary>
        /// Defines the ELClassSectionService.ServesChildrenWithSpecialNeeds nullable property
        /// </summary>
        System.Boolean? ServesChildrenWithSpecialNeeds { get; set; }

        /// <summary>
        /// Defines the ELClassSectionService.ELClassGroupCurriculumType non nullable property
        /// </summary>
        System.String ELClassGroupCurriculumType { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELGroupSizeStandardMet"/> model
        /// </summary>
        Guid? RefELGroupSizeStandardMetId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFrequencyOfService"/> model
        /// </summary>
        Guid? RefFrequencyOfServiceId { get; set; }

    }
}
