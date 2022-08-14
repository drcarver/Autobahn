//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   C_CEDSElementsModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The C_CEDSElements Model
     /// </summary>
    public partial class C_CEDSElementsModel : AutobahnBase, Interfaces.IC_CEDSElements
    {
        /// <summary>
        /// 
        /// </summary>
        public System.String AltName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String ChangedInThisVersionInd { get; set; }

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
        public System.String GlobalID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Boolean HasOptionSet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 TermID { get; set; }

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
