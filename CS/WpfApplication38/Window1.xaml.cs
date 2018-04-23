using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Docking.Customization;
using DevExpress.Xpf.Layout.Core;

namespace WpfApplication38 {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            BarManager manager = new BarManager();
            manager.CreateStandardLayout = true;
            Bar bar = new Bar();
            manager.Bars.Add(bar);
            BarDockInfo TempBarDockInfo = new BarDockInfo { ContainerType = BarContainerType.Top };
            bar.DockInfo = TempBarDockInfo;


            BarButtonItem item1 = new BarButtonItem { Name = "item1", IsVisible = true, Content = "item1" };
            BarButtonItem item2 = new BarButtonItem { Name = "item2", IsVisible = true, Content = "item2" };

            BarSubItem sub1 = new BarSubItem() { Name = "sub1", Content = "sub1" };
            BarSubItem sub2 = new BarSubItem { Name = "sub2", Content = "sub2" };



            sub1.ItemLinks.Add(item1);
            sub1.ItemLinks.Add(sub2);

            sub2.ItemLinks.Add(item2);

            manager.Items.Add(item1);
            manager.Items.Add(sub2);
            manager.Items.Add(item2);
            manager.Items.Add(sub1);

            bar.ItemLinks.Add(sub1);

            grid.Children.Add(manager);


        }
    }
}
