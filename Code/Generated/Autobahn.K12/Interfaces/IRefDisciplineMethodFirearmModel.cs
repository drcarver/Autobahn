//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefDisciplineMethodFirearmModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefDisciplineMethodFirearm Interface Model
     /// </summary>
    public partial interface IRefDisciplineMethodFirearmModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefDisciplineMethodFirearms"/> model
        /// </summary>
        Guid RefDisciplineMethodFirearmsId { get; set; }

    }
}
