//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12LeaGradeOffered.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaGradeOffered
     /// </summary>
    public partial interface IK12LeaGradeOffered : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12Lea"/> model
        /// </summary>
        Guid K12LeaId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefGradeLevel"/> model
        /// </summary>
        Guid RefGradeLevelId { get; set; }

    }
}
