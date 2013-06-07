using System;
using System.Collections.Generic;
using System.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using System.IO;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            var r = typeof(App).GetTypeInfo().Assembly;
            //AssemblyName name = new AssemblyName("ClassLibrary1.dll");
            Assembly assembly = Assembly.Load(new AssemblyName("ClassLibrary1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            var configuration = new ContainerConfiguration().WithAssembly(assembly);
            

            using (var container = configuration.CreateContainer())
            {
                var greeter = container.GetExport<InterfaceLibrary.MainView>();
                this.Frame.Navigate(greeter.GetType(), null);
            }
        }
    }
}
