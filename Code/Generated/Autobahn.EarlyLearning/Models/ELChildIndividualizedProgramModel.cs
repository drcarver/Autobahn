//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildIndividualizedProgramModel.cs
//**********************************************************

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
        /// The status of an individualized services plan for a specified reporting period or on a specified date.
        /// </summary>
        public Guid? IndividualizedProgramId { get; set; }

        /// <summary>
        /// The status of an individualized services plan for a specified reporting period or on a specified date.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// The status of an individualized services plan for a specified reporting period or on a specified date.
        /// </summary>
        public Guid? RefIDEAIEPStatusId { get; set; }

        /// <summary>
        /// The status of an individualized services plan for a specified reporting period or on a specified date.
        /// </summary>
        public Guid? RefIDEAPartCEligibilityCategoryId { get; set; }

    }
}
