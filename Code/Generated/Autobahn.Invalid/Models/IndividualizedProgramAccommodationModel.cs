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
        /// 
        /// </summary>
        public  Applicability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefAccommodationTypeId { get; set; }

    }
}
