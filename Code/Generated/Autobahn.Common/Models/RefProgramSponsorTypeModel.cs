//**********************************************************
//* DomainName: Common Models
//* FileName:   RefProgramSponsorTypeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefProgramSponsorType Model
     /// </summary>
    public partial class RefProgramSponsorType : ReferenceModelBase, Interfaces.IRefProgramSponsorType
    {
        /// <summary>
        /// A type of organization providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.
        /// </summary>
        public System.Int32? RefJurisdiction { get; set; }

    }
}
