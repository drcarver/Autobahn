//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefAlternativeSchoolFocuModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefAlternativeSchoolFocu Model
     /// </summary>
    public partial class RefAlternativeSchoolFocuModel : ReferenceModelBase, IRefAlternativeSchoolFocuModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAlternativeSchoolFocus"/> model
        /// </summary>
        public Guid RefAlternativeSchoolFocusId { get; set; }

    }
}
