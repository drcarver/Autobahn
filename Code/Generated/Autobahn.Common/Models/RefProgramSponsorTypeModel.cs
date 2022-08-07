//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefProgramSponsorTypeModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefProgramSponsorType Model
     /// </summary>
    public partial class RefProgramSponsorTypeModel : ReferenceModelBase, IRefProgramSponsorTypeModel
    {
        /// <summary>
        /// Defines the RefProgramSponsorType.RefJurisdiction nullable property
        /// </summary>
        public System.Int32? RefJurisdiction { get; set; }

    }
}
