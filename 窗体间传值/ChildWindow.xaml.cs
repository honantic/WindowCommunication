using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace 窗体间传值
{
    /// <summary>
    /// ChildWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ChildWindow : Window
    {
        public ChildWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 给父窗体传值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ShowFather_Click(object sender, RoutedEventArgs e)
        {
            this.Title = "我要给父窗体传值";
            this.DialogResult = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
