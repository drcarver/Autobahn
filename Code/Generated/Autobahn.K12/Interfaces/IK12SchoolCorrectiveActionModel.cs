//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12SchoolCorrectiveActionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SchoolCorrectiveActionModel Interface
     /// </summary>
    public partial interface IK12SchoolCorrectiveActionModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12School"/> model
        /// </summary>
        Guid K12SchoolId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefCorrectiveActionType"/> model
        /// </summary>
        Guid RefCorrectiveActionTypeId { get; set; }

    }
}
