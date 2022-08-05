//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12LeaTitleISupportService.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaTitleISupportService
     /// </summary>
    public partial interface IK12LeaTitleISupportService : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12Lea"/> model
        /// </summary>
        Guid K12LeaId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefK12LeaTitleISupportService"/> model
        /// </summary>
        Guid RefK12LeaTitleISupportServiceId { get; set; }

    }
}
