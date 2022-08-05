//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefDisciplineMethodFirearm.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefDisciplineMethodFirearm Interface
     /// </summary>
    public partial interface IRefDisciplineMethodFirearm : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefDisciplineMethodFirearms"/> model
        /// </summary>
        Guid RefDisciplineMethodFirearmsId { get; set; }

    }
}
