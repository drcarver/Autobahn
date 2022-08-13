//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELClassSectionServiceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELClassSectionService Model
     /// </summary>
    public partial class ELClassSectionServiceModel : AutobahnBase, Interfaces.IELClassSectionService
    {
        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        public System.String ELClassGroupCurriculumType { get; set; }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        public Guid ELClassSectionId { get; set; }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        public System.Int32? OldestAgeServed { get; set; }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        public Guid? RefELGroupSizeStandardMetId { get; set; }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        public Guid? RefFrequencyOfServiceId { get; set; }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        public System.Boolean? ServesChildrenWithSpecialNeeds { get; set; }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        public System.Int32? YoungestAgeServed { get; set; }

    }
}
