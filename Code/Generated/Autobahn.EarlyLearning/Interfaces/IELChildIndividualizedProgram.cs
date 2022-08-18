//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELChildIndividualizedProgram.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildIndividualizedProgram Interface
     /// </summary>
    public partial interface IELChildIndividualizedProgram : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        Guid? IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAIEPStatus"/> model
        /// </summary>
        Guid? RefIDEAIEPStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAPartCEligibilityCategory"/> model
        /// </summary>
        Guid? RefIDEAPartCEligibilityCategoryId { get; set; }

    }
}
