//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IRubric.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IRubric Interface
     /// </summary>
    public partial interface IRubric : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Identifier { get; set; }

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
        Guid? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
         UrlReference { get; set; }

    }
}
