//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefIDEAEnvironmentELList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefIDEAEnvironmentEL Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIDEAEnvironmentEL"> List
         /// </summary>
        public static List<RefIDEAEnvironmentEL> RefIDEAEnvironmentELList = new List<RefIDEAEnvironmentEL>
        {
            new RefIDEAEnvironmentEL { Id=Guid.Parse("23d1230f-92a7-4442-9903-7f214c59774f"), Code="REC09YOTHLOC", Description="Other location regular early childhood program (less than 10 hours)", Definition="Other location regular early childhood program (less than 10 hours) is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("79ff1040-a1af-481d-88ae-3ba71895ca21"), Code="REC10YOTHLOC", Description="Other location regular early childhood program (at least 10 hours)", Definition="Other location regular early childhood program (at least 10 hours) is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("28c66d87-6351-42f9-91ee-a714f32cc8ca"), Code="REC09YSVCS", Description="Services regular early childhood program (less than 10 hours)", Definition="Services regular early childhood program (less than 10 hours) is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("3.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("2772861a-d502-4839-96b3-9c985d29579e"), Code="REC10YSVCS", Description="Services regular early childhood program (at least10 hours)", Definition="Services regular early childhood program (at least10 hours)  is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("4.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("4dc9f763-c887-46ad-a02e-1f3ed25929e6"), Code="SC", Description="Separate special education class", Definition="Separate special education class is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("5.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("b9611dc4-8b3d-4ada-a0e4-f68345936bc5"), Code="SS", Description="Separate school", Definition="Separate school is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("6.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("a2dd6eac-5585-4cae-96f4-e25e1f14f0dd"), Code="RF", Description="Residential Facility", Definition="Residential Facility is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("7.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("dafa593f-077c-4a30-8305-4d475b6808fc"), Code="H", Description="Home", Definition="Home is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("8.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("60c717eb-d6c5-4461-a0c3-38b41eacef3f"), Code="SPL", Description="Service provider or other location not in any other category", Definition="Service provider or other location not in any other category  is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefIDEAEnvironmentEL Pick List
         /// </summary>
        public static List<RefIDEAEnvironmentEL> RefIDEAEnvironmentELPickList = new List<RefIDEAEnvironmentEL>
        {
            new RefIDEAEnvironmentEL { Id=Guid.Parse("23d1230f-92a7-4442-9903-7f214c59774f"), Code="REC09YOTHLOC", Description="Other location regular early childhood program (less than 10 hours)", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("79ff1040-a1af-481d-88ae-3ba71895ca21"), Code="REC10YOTHLOC", Description="Other location regular early childhood program (at least 10 hours)", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("28c66d87-6351-42f9-91ee-a714f32cc8ca"), Code="REC09YSVCS", Description="Services regular early childhood program (less than 10 hours)", SortOrder=Convert.ToDecimal("3.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("2772861a-d502-4839-96b3-9c985d29579e"), Code="REC10YSVCS", Description="Services regular early childhood program (at least10 hours)", SortOrder=Convert.ToDecimal("4.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("4dc9f763-c887-46ad-a02e-1f3ed25929e6"), Code="SC", Description="Separate special education class", SortOrder=Convert.ToDecimal("5.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("b9611dc4-8b3d-4ada-a0e4-f68345936bc5"), Code="SS", Description="Separate school", SortOrder=Convert.ToDecimal("6.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("a2dd6eac-5585-4cae-96f4-e25e1f14f0dd"), Code="RF", Description="Residential Facility", SortOrder=Convert.ToDecimal("7.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("dafa593f-077c-4a30-8305-4d475b6808fc"), Code="H", Description="Home", SortOrder=Convert.ToDecimal("8.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("60c717eb-d6c5-4461-a0c3-38b41eacef3f"), Code="SPL", Description="Service provider or other location not in any other category", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
