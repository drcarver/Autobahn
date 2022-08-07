//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12ProgramOrServiceView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12ProgramOrServiceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12ProgramOrServiceView : ContentPage
    {
        /// <summary>
        /// Inject the IK12ProgramOrServiceViewModel as the data context for the view
        /// </summary>
        public K12ProgramOrServiceView(IK12ProgramOrServiceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
