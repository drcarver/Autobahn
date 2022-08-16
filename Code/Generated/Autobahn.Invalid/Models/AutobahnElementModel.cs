//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   AutobahnElementModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The AutobahnElement Model
     /// </summary>
    public partial class AutobahnElementModel : AutobahnBase, Interfaces.IAutobahnElement
    {
        /// <summary>
        /// 
        /// </summary>
        public System.String AltName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Collections.Generic.List`1[System.Nullable`1[System.Guid]] AutobahnDomainList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Collections.Generic.List`1[System.Nullable`1[System.Guid]] AutobahnTableList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String ChangeNotes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String ElementName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid GlobalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String HasOptionSet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String TechnicalName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String TermID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String URL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String UsageNotes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Version { get; set; }

    }
}
