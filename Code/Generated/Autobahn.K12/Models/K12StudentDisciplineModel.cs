//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentDisciplineModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentDiscipline Model
     /// </summary>
    public partial class K12StudentDisciplineModel : AutobahnBase, Interfaces.IK12StudentDiscipline
    {
        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public System.DateTime? DisciplinaryActionEndDate { get; set; }

    }
}
