//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramAccommodationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IndividualizedProgramAccommodation Model
     /// </summary>
    public partial class IndividualizedProgramAccommodationModel : AutobahnBase, Interfaces.IIndividualizedProgramAccommodation
    {
        /// <summary>
        /// The specific accommodation necessary for assessment or instruction.
        /// </summary>
        public System.String Applicability { get; set; }

        /// <summary>
        /// The specific accommodation necessary for assessment or instruction.
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// The specific accommodation necessary for assessment or instruction.
        /// </summary>
        public Guid? RefAccommodationTypeId { get; set; }

    }
}
