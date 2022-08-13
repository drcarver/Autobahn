//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELClassSectionService.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELClassSectionService Interface
     /// </summary>
    public partial interface IELClassSectionService : IAutobahnBase
    {
        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        System.String ELClassGroupCurriculumType { get; set; }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        Guid ELClassSectionId { get; set; }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        System.Int32? OldestAgeServed { get; set; }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        Guid? RefELGroupSizeStandardMetId { get; set; }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        Guid? RefFrequencyOfServiceId { get; set; }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        System.Boolean? ServesChildrenWithSpecialNeeds { get; set; }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        System.Int32? YoungestAgeServed { get; set; }

    }
}
