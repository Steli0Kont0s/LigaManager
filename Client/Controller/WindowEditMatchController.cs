using Client.Framework;
using Client.ViewModels;
using Client.Views;
using Server.WcfModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controller
{
	class WindowEditMatchController
	{
		private WindowEditMatch mView;
		private WindowEditMatchViewModel mViewModel;
		public WcfMatch EditMatch(WcfMatch match)
		{
			mView = new WindowEditMatch();
			mViewModel = new WindowEditMatchViewModel
			{
				Match = match,
				
				OkCommand = new RelayCommand(ExecuteOkCommand),
				CancelCommand = new RelayCommand(ExecuteCancelCommand)
			};
			mView.Title = "Edit Match";
			mView.DataContext = mViewModel;

			return mView.ShowDialog() == true ? mViewModel.Match : null;
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
