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

namespace 构造函数_委托
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

        ShowMessage sm;
        string value="";
        public ChildWindow(ShowMessage _sm,string _value)
        {
            InitializeComponent();
            sm = _sm;
            value = _value;
        }

        /// <summary>
        /// 加载事件，显示父窗体传递来的值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(value, "子窗体提示框");
        }


        /// <summary>
        /// 调用父窗体传来的委托函数，给父窗体传值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ShowFather_Click(object sender, RoutedEventArgs e)
        {
            sm.Invoke("这是来自子窗体的信息！");
        }


    }
}
