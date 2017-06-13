using Client.Framework;
using Client.ViewModels;
using Client.Views;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controller
{
	class WindowAddController
	{
		private WindowAdd mView;

		public Bettor AddBettor()
		{
			mView = new WindowAdd();
			var viewModel = new WindowAddViewModel
			{
				Model = new Bettor(),
				OkCommand = new RelayCommand(ExecuteOkCommand),
				CancelCommand = new RelayCommand(ExecuteCancelCommand)
			};

			mView.DataContext = viewModel;
			return mView.ShowDialog() == true ? viewModel.Model : null;
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
