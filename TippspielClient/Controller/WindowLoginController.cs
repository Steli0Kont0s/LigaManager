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
	class WindowLoginController
	{
		private WindowLogin mView;
		private WindowLoginViewModel mViewModel;

		public void Initialize()
		{
			mView = new WindowLogin();
			mViewModel = new WindowLoginViewModel
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
				MainWindowController controller = new MainWindowController(WcfHelper.client.GetBettorByName(mViewModel.UserName));
				mView.Close();
			}
			else
			{
				MessageBox.Show("User existiert nicht");
			}
		}
	}
}
