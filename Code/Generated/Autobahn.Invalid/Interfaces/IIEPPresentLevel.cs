//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIEPPresentLevel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIEPPresentLevel Interface
     /// </summary>
    public partial interface IIEPPresentLevel : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? AcademicDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FunctionalDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         GeneralEducationDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ParentConcernDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PreschoolDescription { get; set; }

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
         StudentConcernDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StudentStrengthsDescription { get; set; }

    }
}
