//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IncidentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The Incident Model
     /// </summary>
    public partial class IncidentModel : AutobahnBase, Interfaces.IIncident
    {
        /// <summary>
        /// A locally assigned unique identifier (within the school or school district) to identify each specific incident or occurrence. The same identifier should be used to document the entire incident even if it included multiple offenses and multiple offenders.
        /// </summary>
        public System.String IncidentIdentifier { get; set; }

    }
}
