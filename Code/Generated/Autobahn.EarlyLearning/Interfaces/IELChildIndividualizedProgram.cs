//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELChildIndividualizedProgram.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildIndividualizedProgram
     /// </summary>
    public partial interface IELChildIndividualizedProgram : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        Guid? IndividualizedProgramId { get; set; }

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
