using ASM_APP.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ASM_APP.Views
{

 
    public sealed partial class My_Acount : Page
    {
        Member member = new Member();
        public My_Acount()
        {
            this.InitializeComponent();
            LoadMemberInformation();
        }
        private async void LoadMemberInformation()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "lMyHzmDDg4vQik4XAmaOap9fy9VsDbH1HP6TMdJUCh3NHexd4rib2ASn05rCPpPG");
            var response = httpClient.GetAsync("https://2-dot-backup-server-002.appspot.com/_api/v2/members/information");
            var content = await response.Result.Content.ReadAsStringAsync();
            Debug.WriteLine(content);
            member = JsonConvert.DeserializeObject<Member>(content);
            Debug.WriteLine(member.email);
            this.txt_fullname.Text = member.firstName + " " + member.lastName;
            this.txt_phone.Text = member.phone;
            this.txt_email.Text = member.email;
            this.txt_birthday.Text = member.birthday;
            this.txt_address.Text = member.address;
            this.img_avatar.Source = new BitmapImage(new Uri(member.avatar, UriKind.Absolute));
        }
    }
}
