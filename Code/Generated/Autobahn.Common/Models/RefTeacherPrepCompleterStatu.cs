//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTeacherPrepCompleterStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefTeacherPrepCompleterStatu Model
     /// </summary>
    public partial class RefTeacherPrepCompleterStatu : ReferenceModelBase, IRefTeacherPrepCompleterStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTeacherPrepCompleterStatus"/> model
        /// </summary>
        public Guid RefTeacherPrepCompleterStatusId { get; set; }

    }
}
