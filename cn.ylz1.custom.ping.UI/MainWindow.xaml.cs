using cn.ylz1.custom.ping.Code;
using Native.Tool.IniConfig;
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

namespace cn.ylz1.custom.ping.UI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IniConfig ini = new IniConfig(Common.CQApi.AppDirectory + "config.ini");
            ini.Load();
            try
            {
                txtMaster.Text = ini.Object["System"]["Master"];
            }
            catch { }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            IniConfig ini = new IniConfig(Common.CQApi.AppDirectory + "config.ini");
            ini.Load();
            ini.Object["System"]["Master"] = txtMaster.Text;
            ini.Save();
            MessageBox.Show("保存成功！");
        }
    }
}
