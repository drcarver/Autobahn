//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CourseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The Course Model
     /// </summary>
    public partial class CourseModel : AutobahnBase, Interfaces.ICourse
    {
    }
}
