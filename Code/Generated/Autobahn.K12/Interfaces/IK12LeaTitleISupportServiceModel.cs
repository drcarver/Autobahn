//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12LeaTitleISupportServiceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaTitleISupportServiceModel Interface
     /// </summary>
    public partial interface IK12LeaTitleISupportServiceModel : IAutobahnBase
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
