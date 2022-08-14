//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RefCountyModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

using Autobahn.Invalid.Interfaces;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The RefCounty Model
     /// </summary>
    public partial class RefCounty : ReferenceModelBase, Interfaces.IRefCounty
    {
    }
}
