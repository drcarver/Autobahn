//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SchoolView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SchoolView : ContentPage
    {
        /// <summary>
        /// Inject the IK12School View Model as the data context for the view
        /// </summary>
        public K12SchoolView(Interfaces.IK12School vm)
        {
            BindingContext  = vm;
        }
    }
}
