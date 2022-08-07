//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefK12LeaTitleISupportServiceModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefK12LeaTitleISupportService Model
     /// </summary>
    public partial class RefK12LeaTitleISupportServiceModel : ReferenceModelBase, IRefK12LeaTitleISupportServiceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefK12LEATitleISupportService"/> model
        /// </summary>
        public Guid RefK12LEATitleISupportServiceId { get; set; }

    }
}
