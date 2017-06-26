using Client.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TippspielClient.ViewModels;
using TippspielClient.Views;

namespace TippspielClient.Controller
{
	class MainWindowController
	{
		private MainWindow mView;
		private MainWindowViewModel mViewModel;

		public void Initialize()
		{
			mView = new MainWindow();
			mViewModel = new MainWindowViewModel
			{
				LoginCommand = new RelayCommand(ExecuteLoginCommand),
			};
			mView.DataContext = mViewModel;
			WcfHelper.Initialize();

			mView.ShowDialog();
		}

		private void ExecuteLoginCommand(object obj)
		{
			if (WcfHelper.client.CheckBettor(mViewModel.UserName))
			{
				mView.Hide();
				UserPanelController controller = new UserPanelController(WcfHelper.client.GetBettorByName(mViewModel.UserName));
				mView.Close();
			}
			else
			{
				MessageBox.Show("User existiert nicht");
			}
		}
	}
}
