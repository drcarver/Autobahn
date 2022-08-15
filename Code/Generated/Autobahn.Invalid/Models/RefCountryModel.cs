//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RefCountryModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

using Autobahn.Invalid.Interfaces;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The RefCountry Model
     /// </summary>
    public partial class RefCountry : ReferenceModelBase, Interfaces.IRefCountry
    {
    }
}
