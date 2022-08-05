//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefEarlyChildhoodProgramEnrollmentType.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.EarlyLearning.Interfaces;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The RefEarlyChildhoodProgramEnrollmentType Model
     /// </summary>
    public partial class RefEarlyChildhoodProgramEnrollmentType : ReferenceModelBase, IRefEarlyChildhoodProgramEnrollmentType
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefEarlyChildhoodProgramType"/> model
        /// </summary>
        public Guid RefEarlyChildhoodProgramTypeId { get; set; }

    }
}
