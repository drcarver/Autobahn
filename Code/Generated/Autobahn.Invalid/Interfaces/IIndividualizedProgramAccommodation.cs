//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramAccommodation.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramAccommodation Interface
     /// </summary>
    public partial interface IIndividualizedProgramAccommodation : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         Applicability { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefAccommodationTypeId { get; set; }

    }
}
