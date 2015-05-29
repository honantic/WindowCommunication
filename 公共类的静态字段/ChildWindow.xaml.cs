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

namespace 公共类的静态字段
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
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Title = InfoClass.Title;
        }

        /// <summary>
        /// 修改公共类的静态字段，变相为父窗体赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ShowFather_Click(object sender, RoutedEventArgs e)
        {
            InfoClass.Title = "我的名字也是来自公共类！";
            InfoClass.Message = "这是子窗体留下的信息！";
            this.DialogResult = true;
        }
    }
}
