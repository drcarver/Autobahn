//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentSessionView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentSessionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentSessionView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentSession View Model as the data context for the view
        /// </summary>
        public K12StudentSessionView(Interfaces.IK12StudentSession vm)
        {
            BindingContext  = vm;
        }
    }
}
