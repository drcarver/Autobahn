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
        /// The title of the rubric.
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// The title of the rubric.
        /// </summary>
        System.String Title { get; set; }

        /// <summary>
        /// The title of the rubric.
        /// </summary>
        System.String UrlReference { get; set; }

    }
}
