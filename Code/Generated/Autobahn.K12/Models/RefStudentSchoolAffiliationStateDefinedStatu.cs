//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefStudentSchoolAffiliationStateDefinedStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefStudentSchoolAffiliationStateDefinedStatu Model
     /// </summary>
    public partial class RefStudentSchoolAffiliationStateDefinedStatu : ReferenceModelBase, IRefStudentSchoolAffiliationStateDefinedStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefStudentSchoolAffiliationStateDefinedStatus"/> model
        /// </summary>
        public Guid RefStudentSchoolAffiliationStateDefinedStatusId { get; set; }

    }
}
