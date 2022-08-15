//***************************************************************************
//* DomainName: Competencies Interfaces (used by both models and View Models
//* FileName:   ICompetencyFramework.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencyFramework Interface
     /// </summary>
    public partial interface ICompetencyFramework : IAutobahnBase
    {
        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        System.String URI { get; set; }

    }
}
