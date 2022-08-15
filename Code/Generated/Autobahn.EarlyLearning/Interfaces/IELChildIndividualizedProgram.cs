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
        /// The status of an individualized services plan for a specified reporting period or on a specified date.
        /// </summary>
        Guid? RefIDEAIEPStatusId { get; set; }

    }
}
