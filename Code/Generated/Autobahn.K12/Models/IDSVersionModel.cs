//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IDSVersionModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The IDSVersion Model
     /// </summary>
    public partial class IDSVersionModel : AutobahnBase, Interfaces.IIDSVersion
    {
        public System.Boolean CurrentVersion { get; set; }

        public System.DateTime IDSVersionDate { get; set; }

        public System.String IDSVersionNumber { get; set; }

    }
}
