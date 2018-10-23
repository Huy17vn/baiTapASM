using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ASM_APP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SplitView : Page
    {
        private string CurrentTag = "";
        public static long currentMemberId = 1538727452278;
        public SplitView()
        {
            this.InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (CurrentTag == radio.Tag.ToString())
            {
                return;
            }
            switch (radio.Tag.ToString())
            {
                case "myAccount":
                    CurrentTag = "myAccount";
                    this.MyFrame.Navigate(typeof(Views.Login));
                    break;
                case "accountInformation":
                    CurrentTag = "accountInformation";
                    this.MyFrame.Navigate(typeof(Views.My_Acount));
                    break;
                case "Music":
                    CurrentTag = "Music";
                    this.MyFrame.Navigate(typeof(Views.PivoDemoWithListView));
                    break;
                case "Setting":
                    CurrentTag = "Setting";
                    this.MyFrame.Navigate(typeof(Views.Login));
                    break;
                default:
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.SplitVia.IsPaneOpen = !this.SplitVia.IsPaneOpen;
        }
    }
}
