//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingCommMgmtComponentSystemTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingCommMgmtComponentSystemType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingCommMgmtComponentSystemType"> List
         /// </summary>
        public static List<RefBuildingCommMgmtComponentSystemType> RefBuildingCommMgmtComponentSystemTypeList = new List<RefBuildingCommMgmtComponentSystemType>
        {
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("71ae30ba-48cf-4733-a9ae-2ef96e4234fe"), Code="02500", Description="Data", Definition="Data is specified as the type of system, interface, and management components for carrying voice, video, and data throughout a building.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("e468a928-8a18-4f43-8e41-cb772267b19f"), Code="14905", Description="Integrated (voice, data, video, etc.)", Definition="Integrated (voice, data, video, etc.) is specified as the type of system, interface, and management components for carrying voice, video, and data throughout a building.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("aa4af572-4813-46e3-9e92-370ff6ede062"), Code="02501", Description="Public address system", Definition="Public address system is specified as the type of system, interface, and management components for carrying voice, video, and data throughout a building.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("76e65313-ea6c-4fd3-bc17-6f1c710de9d7"), Code="02499", Description="Video", Definition="Video is specified as the type of system, interface, and management components for carrying voice, video, and data throughout a building.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("dcf64375-6974-4cd1-b56d-44d1f7afc06a"), Code="02498", Description="Voice", Definition="Voice is specified as the type of system, interface, and management components for carrying voice, video, and data throughout a building.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("f1716092-7af3-475f-9fa1-3c147454918c"), Code="09999", Description="Other", Definition="Other is specified as the type of system, interface, and management components for carrying voice, video, and data throughout a building.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefBuildingCommMgmtComponentSystemType Pick List
         /// </summary>
        public static List<RefBuildingCommMgmtComponentSystemType> RefBuildingCommMgmtComponentSystemTypePickList = new List<RefBuildingCommMgmtComponentSystemType>
        {
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("71ae30ba-48cf-4733-a9ae-2ef96e4234fe"), Code="02500", Description="Data", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("e468a928-8a18-4f43-8e41-cb772267b19f"), Code="14905", Description="Integrated (voice, data, video, etc.)", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("aa4af572-4813-46e3-9e92-370ff6ede062"), Code="02501", Description="Public address system", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("76e65313-ea6c-4fd3-bc17-6f1c710de9d7"), Code="02499", Description="Video", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("dcf64375-6974-4cd1-b56d-44d1f7afc06a"), Code="02498", Description="Voice", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("f1716092-7af3-475f-9fa1-3c147454918c"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
