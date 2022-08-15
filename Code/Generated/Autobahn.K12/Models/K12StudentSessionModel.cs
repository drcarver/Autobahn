//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentSessionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentSession Model
     /// </summary>
    public partial class K12StudentSessionModel : AutobahnBase, Interfaces.IK12StudentSession
    {
        /// <summary>
        /// A measure of average performance in all courses taken by a person during a given session. This is obtained by dividing the total grade points received by the number of credits attempted for the same session.
        /// </summary>
        public System.Decimal? GradePointAverageGivenSession { get; set; }

    }
}
