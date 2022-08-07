//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolGradeLevelsApprovedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SchoolGradeLevelsApproved Model
     /// </summary>
    public partial class K12SchoolGradeLevelsApprovedModel : AutobahnBase, Interfaces.IK12SchoolGradeLevelsApprovedModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12School"/> model
        /// </summary>
        public Guid K12SchoolId { get; set; }

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
