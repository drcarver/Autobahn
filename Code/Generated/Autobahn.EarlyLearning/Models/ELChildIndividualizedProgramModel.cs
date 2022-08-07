//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildIndividualizedProgramModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildIndividualizedProgram Model
     /// </summary>
    public partial class ELChildIndividualizedProgramModel : AutobahnBase, Interfaces.IELChildIndividualizedProgramModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid? IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAIEPStatus"/> model
        /// </summary>
        public Guid? RefIDEAIEPStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAPartCEligibilityCategory"/> model
        /// </summary>
        public Guid? RefIDEAPartCEligibilityCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
