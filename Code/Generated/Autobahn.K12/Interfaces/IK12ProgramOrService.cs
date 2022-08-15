//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12ProgramOrService.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12ProgramOrService Interface
     /// </summary>
    public partial interface IK12ProgramOrService : IAutobahnBase
    {
        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        Guid? RefMepSessionTypeId { get; set; }

    }
}
