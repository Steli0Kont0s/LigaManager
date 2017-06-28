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
	class WindowAddSeasonController
	{
		private WindowAddSeason mView;

		public WcfSeason AddSeason()
		{
			mView = new WindowAddSeason();
			var viewModel = new WindowAddSeasonViewModel
			{
				Season = new WcfSeason(),
				OkCommand = new RelayCommand(ExecuteOkCommand),
				CancelCommand = new RelayCommand(ExecuteCancelCommand)
			};

			viewModel.Season.Sequence = 0;
			viewModel.Season.StartDate = DateTime.Now;

			mView.DataContext = viewModel;
			return mView.ShowDialog() == true ? viewModel.Season : null;
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
