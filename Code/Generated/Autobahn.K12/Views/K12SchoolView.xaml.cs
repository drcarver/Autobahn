//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SchoolView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SchoolView : ContentPage
    {
        /// <summary>
        /// Inject the IK12SchoolViewModel as the data context for the view
        /// </summary>
        public K12SchoolView(IK12SchoolViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
