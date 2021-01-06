using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Windows.Controls;

namespace testingApp.DataModel.User
{
    /// <summary>
    /// UserInfoViewController.xaml 的互動邏輯
    /// </summary>
    public partial class UserInfoViewController : UserControl
    {
        public UserInfoViewController()
        {
            InitializeComponent();
        }
        public void UpdateInfo(ObservableCollection<UserModel> users)
        {
            userInfoPanel.ItemsSource = users;
        }
    }
}
