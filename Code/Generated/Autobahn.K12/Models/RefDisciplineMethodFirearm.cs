//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefDisciplineMethodFirearm.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefDisciplineMethodFirearm Model
     /// </summary>
    public partial class RefDisciplineMethodFirearm : ReferenceModelBase, IRefDisciplineMethodFirearm
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefDisciplineMethodFirearms"/> model
        /// </summary>
        public Guid RefDisciplineMethodFirearmsId { get; set; }

    }
}
