//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12SchoolGradeOffered.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SchoolGradeOffered
     /// </summary>
    public partial interface IK12SchoolGradeOffered : IAutobahnBase
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
