//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12LeaTitleISupportService.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaTitleISupportService Interface
     /// </summary>
    public partial interface IK12LeaTitleISupportService : IAutobahnBase
    {
        /// <summary>
        /// The type of support services provided to students in Title I programs.
        /// </summary>
        Guid K12LeaId { get; set; }

        /// <summary>
        /// The type of support services provided to students in Title I programs.
        /// </summary>
        Guid RefK12LeaTitleISupportServiceId { get; set; }

    }
}
