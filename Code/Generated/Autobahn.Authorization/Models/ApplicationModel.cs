//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ApplicationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The Application Model
     /// </summary>
    public partial class ApplicationModel : AutobahnBase, Interfaces.IApplication
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Uri { get; set; }

    }
}
