//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12SeaModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SeaModel Interface
     /// </summary>
    public partial interface IK12SeaModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStateANSICode"/> model
        /// </summary>
        Guid? RefStateANSICodeId { get; set; }

    }
}
