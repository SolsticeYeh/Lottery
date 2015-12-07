using System;
using System.Collections.Generic;
using System.Diagnostics;
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

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace Lottery
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DispatcherTimer dt = new DispatcherTimer();
        static int time = 0;
        public MainPage()
        {
            this.InitializeComponent();
            dt.Interval = new TimeSpan(100);
            dt.Tick += Dt_Tick;
            dt.Start();
        }
        private void Dt_Tick(object sender, object e)
        {
            Debug.WriteLine("{0}", time++);
            num.Text = time.ToString();
            if (time == 100)
            {
                time = 0;
            }
        }
        private async void click_Click(object sender, RoutedEventArgs e)
        {
            TextBlock luckDog = new TextBlock();
            luckDog.Text = num.Text;
            luckDog.HorizontalAlignment = HorizontalAlignment.Left;
            choujiang.Children.Add(luckDog);
        }
    }
}
