//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyChildhoodProgramTypeOfferedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The EarlyChildhoodProgramTypeOffered Model
     /// </summary>
    public partial class EarlyChildhoodProgramTypeOfferedModel : AutobahnBase, Interfaces.IEarlyChildhoodProgramTypeOffered
    {
        /// <summary>
        /// The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.
        /// </summary>
        public Guid RefEarlyChildhoodProgramEnrollmentTypeId { get; set; }

    }
}
