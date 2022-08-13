//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaTitleISupportServiceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaTitleISupportService Model
     /// </summary>
    public partial class K12LeaTitleISupportServiceModel : AutobahnBase, Interfaces.IK12LeaTitleISupportService
    {
        /// <summary>
        /// The type of support services provided to students in Title I programs.
        /// </summary>
        public Guid K12LeaId { get; set; }

        /// <summary>
        /// The type of support services provided to students in Title I programs.
        /// </summary>
        public Guid RefK12LeaTitleISupportServiceId { get; set; }

    }
}
