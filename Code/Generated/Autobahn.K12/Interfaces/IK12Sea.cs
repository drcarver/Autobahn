//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12Sea.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12Sea Interface
     /// </summary>
    public partial interface IK12Sea : IAutobahnBase
    {
        /// <summary>
        /// The American National Standards Institute (ANSI) two-digit code for the state.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// The American National Standards Institute (ANSI) two-digit code for the state.
        /// </summary>
        Guid? RefStateANSICodeId { get; set; }

    }
}
