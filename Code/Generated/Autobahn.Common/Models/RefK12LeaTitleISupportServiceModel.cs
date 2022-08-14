//**********************************************************
//* DomainName: Common Models
//* FileName:   RefK12LeaTitleISupportServiceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefK12LeaTitleISupportService Model
     /// </summary>
    public partial class RefK12LeaTitleISupportService : ReferenceModelBase, Interfaces.IRefK12LeaTitleISupportService
    {
        /// <summary>
        /// The type of support services provided to students in Title I programs.
        /// </summary>
        public Guid RefK12LEATitleISupportServiceId { get; set; }

    }
}
