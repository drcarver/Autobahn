//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AutobahnElementModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The AutobahnElement Model
     /// </summary>
    public partial class AutobahnElementModel : AutobahnBase, Interfaces.IAutobahnElement
    {
        public System.String AltName { get; set; }

        public System.Collections.Generic.List`1[System.Nullable`1[System.Guid]] AutobahnDomainList { get; set; }

        public System.Collections.Generic.List`1[System.Nullable`1[System.Guid]] AutobahnTableList { get; set; }

        public System.String ChangeNotes { get; set; }

        public System.String ElementName { get; set; }

        public System.String Format { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IGlobal"/> model
        /// </summary>
        public Guid GlobalId { get; set; }

        public System.String HasOptionSet { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="I"/> model
        /// </summary>
        public Guid Id { get; set; }

        public System.String TechnicalName { get; set; }

        public System.String TermID { get; set; }

        public System.String URL { get; set; }

        public System.String UsageNotes { get; set; }

        public System.String Version { get; set; }

    }
}
