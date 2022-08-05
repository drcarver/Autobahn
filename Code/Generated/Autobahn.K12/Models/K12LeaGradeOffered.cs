//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaGradeOffered.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaGradeOffered
     /// </summary>
    public partial class K12LeaGradeOffered : AutobahnBase, Interfaces.IK12LeaGradeOffered
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12Lea"/> model
        /// </summary>
        public Guid K12LeaId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefGradeLevel"/> model
        /// </summary>
        public Guid RefGradeLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
