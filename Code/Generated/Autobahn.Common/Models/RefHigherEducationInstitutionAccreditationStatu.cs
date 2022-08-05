//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefHigherEducationInstitutionAccreditationStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefHigherEducationInstitutionAccreditationStatu Model
     /// </summary>
    public partial class RefHigherEducationInstitutionAccreditationStatu : ReferenceModelBase, IRefHigherEducationInstitutionAccreditationStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefHigherEducationInstitutionAccreditationStatus"/> model
        /// </summary>
        public Guid RefHigherEducationInstitutionAccreditationStatusId { get; set; }

    }
}
