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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 构造函数_委托
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 通过自定义构造函数，给子窗体传值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ShowChild_Click(object sender, RoutedEventArgs e)
        {
            ChildWindow child = new ChildWindow(ShowErrorMessage,"这是来自父窗体的信息");
            child.Show();
        }

        /// <summary>
        /// 符合委托函数ShowMessage返回类型和签名的函数实例
        /// </summary>
        /// <param name="value"></param>
        private void ShowErrorMessage(string value)
        {
            MessageBox.Show(value,"父窗体提示框");
        }
    }
}
