//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ServiceProviderModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ServiceProvider Model
     /// </summary>
    public partial class ServiceProviderModel : AutobahnBase, Interfaces.IServiceProvider
    {
    }
}
