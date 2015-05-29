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

namespace 公共类的静态字段
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
        /// 实例化子窗体，为公用类静态字段赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ShowChild_Click(object sender, RoutedEventArgs e)
        {
            InfoClass.Title = "我的名字来自公共类！";
            ChildWindow child = new ChildWindow();
            child.ShowDialog();

            if (child.DialogResult==true)
            {
                this.Title=InfoClass.Title;
                MessageBox.Show(InfoClass.Message);
            }
        }
    }
}
