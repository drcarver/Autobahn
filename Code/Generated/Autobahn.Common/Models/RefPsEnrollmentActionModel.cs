//**********************************************************
//* DomainName: Common Models
//* FileName:   RefPsEnrollmentActionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefPsEnrollmentAction Model
     /// </summary>
    public partial class RefPsEnrollmentAction : ReferenceModelBase, Interfaces.IRefPsEnrollmentAction
    {
        /// <summary>
        /// The action taken with respect to postsecondary enrollment by the student who graduated from the school, LEA or state in the past two years.
        /// </summary>
        public System.Int32? RefJurisdiction { get; set; }

    }
}
