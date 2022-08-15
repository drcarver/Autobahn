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
        public System.String GlobalID { get; set; }

    }
}
