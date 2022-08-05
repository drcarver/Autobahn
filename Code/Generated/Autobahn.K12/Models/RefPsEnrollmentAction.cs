//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefPsEnrollmentAction.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefPsEnrollmentAction Model
     /// </summary>
    public partial class RefPsEnrollmentAction : ReferenceModelBase, IRefPsEnrollmentAction
    {
        /// <summary>
        /// Defines the RefPsEnrollmentAction.RefJurisdiction nullable property
        /// </summary>
        public System.Int32? RefJurisdiction { get; set; }

    }
}
