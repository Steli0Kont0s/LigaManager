using Client.Framework;
using Client.ViewModels;
using Client.Views;
using Server.WcfModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controller
{
	class WindowAddBettorController
	{
		private WindowBettor mView;

		public WcfBettor AddBettor()
		{
			mView = new WindowBettor();
			var viewModel = new WindowBettorViewModel
			{
				Bettor = new WcfBettor(),
				OkCommand = new RelayCommand(ExecuteOkCommand),
				CancelCommand = new RelayCommand(ExecuteCancelCommand)
			};

			mView.Title = "Add Bettor";
			mView.DataContext = viewModel;
			return mView.ShowDialog() == true ? viewModel.Bettor : null;
		}

		private void ExecuteOkCommand(object obj)
		{
			mView.DialogResult = true;
			mView.Close();
		}

		private void ExecuteCancelCommand(object obj)
		{
			mView.DialogResult = false;
			mView.Close();
		}
	}
}
