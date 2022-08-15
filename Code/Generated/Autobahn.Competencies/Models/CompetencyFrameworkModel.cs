//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyFrameworkModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencyFramework Model
     /// </summary>
    public partial class CompetencyFrameworkModel : AutobahnBase, Interfaces.ICompetencyFramework
    {
        /// <summary>
        /// An unambiguous reference to the competency framework using a network-resolvable URI.
        /// </summary>
        public System.String URI { get; set; }

    }
}
