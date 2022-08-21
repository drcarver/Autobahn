// See https://aka.ms/new-console-template for more
// information
// Install-Package Microsoft.EntityFrameworkCore.SqlServer –Pre
// Install - Package Microsoft.EntityFrameworkCore.Tools –Pre
// Install-Package Microsoft.EntityFrameworkCore.SqlServer.Design –Pre
// Scaffold-DbContext 'Data Source=DESKTOP-6CQUBDS\SQLEXPRESS;Initial Catalog=Autibahn;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False' Microsoft.EntityFrameworkCore.SqlServer -DataAnnotations -Context Autobahn -OutputDir Entities
using Microsoft.Data.SqlClient;

Console.WriteLine("Hello, World!");

var cnnstring= @"Data Source=DESKTOP-6CQUBDS\SQLEXPRESS\SQLEXPRESS;Initial Catalog=Autobahn;Trusted_Connection=True;";

var cnn = new SqlConnection(cnnstring);
cnn.Open();

cnn.Close();