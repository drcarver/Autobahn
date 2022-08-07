//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaGradeLevelsApprovedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaGradeLevelsApproved Model
     /// </summary>
    public partial class K12LeaGradeLevelsApprovedModel : AutobahnBase, Interfaces.IK12LeaGradeLevelsApprovedModel
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
