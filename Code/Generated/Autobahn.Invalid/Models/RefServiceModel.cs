//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RefServiceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

using Autobahn.Invalid.Interfaces;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The RefService Model
     /// </summary>
    public partial class RefService : ReferenceModelBase, Interfaces.IRefService
    {
    }
}
