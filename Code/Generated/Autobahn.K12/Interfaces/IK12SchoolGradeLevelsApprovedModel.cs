//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12SchoolGradeLevelsApprovedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SchoolGradeLevelsApprovedModel Interface
     /// </summary>
    public partial interface IK12SchoolGradeLevelsApprovedModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12School"/> model
        /// </summary>
        Guid K12SchoolId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefGradeLevel"/> model
        /// </summary>
        Guid RefGradeLevelId { get; set; }

    }
}
