//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildIndividualizedProgramModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildIndividualizedProgram Model
     /// </summary>
    public partial class ELChildIndividualizedProgramModel : AutobahnBase, Interfaces.IELChildIndividualizedProgram
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        public Guid? IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAIEPStatus"/> model
        /// </summary>
        public Guid? RefIDEAIEPStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAPartCEligibilityCategory"/> model
        /// </summary>
        public Guid? RefIDEAPartCEligibilityCategoryId { get; set; }

    }
}
