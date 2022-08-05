//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefK12LeaTitleISupportService.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefK12LeaTitleISupportService Interface
     /// </summary>
    public partial interface IRefK12LeaTitleISupportService : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefK12LEATitleISupportService"/> model
        /// </summary>
        Guid RefK12LEATitleISupportServiceId { get; set; }

    }
}
