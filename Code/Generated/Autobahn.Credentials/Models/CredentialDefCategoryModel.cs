//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefCategoryModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefCategory Model
     /// </summary>
    public partial class CredentialDefCategoryModel : AutobahnBase, Interfaces.ICredentialDefCategory
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CategorySystem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

    }
}
