using DevExpress.Xpo;
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
using testingApp.DataModel.User;
using testingApp.DataModel;
using System.Collections.ObjectModel;

namespace testingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        ObservableCollection<UserModel> users = new ObservableCollection<UserModel>();

        public MainWindow()
        {
            InitializeComponent();
            Init.GetRef();
        }

        private void TestButtonClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("oao?");
            var uow = new UnitOfWork();
            var query = uow.Query<UserModel>().ToList();
            if (query == null)
            {
                MessageBox.Show("null");
            }
            if (query.Count > 0)
            {
                MessageBox.Show($"arr count:{query.Count}");
            }
            users.Clear();
            foreach(var q in query)
            {
                users.Add(q);
            }
            userInfoPanel.UpdateInfo(users);
        }

        private void AddButtonClicked(object sender, RoutedEventArgs e)
        {
            var uow = new UnitOfWork();
            var user = new UserModel(uow)
            {
                age = 123,
                address = "qqqqq",
                username = "0.0"
            };
            user.Save();
            uow.CommitChanges();
            MessageBox.Show("add new record");
        }
    }
}