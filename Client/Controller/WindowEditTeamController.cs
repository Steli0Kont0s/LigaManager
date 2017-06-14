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
	class WindowEditTeamController
	{
		private WindowTeam mView;

		public WcfTeam EditTeam(WcfTeam newTeam)
		{
			mView = new WindowTeam();
			var viewModel = new WindowTeamViewModel
			{
				team = newTeam,
				OkCommand = new RelayCommand(ExecuteOkCommand),
				CancelCommand = new RelayCommand(ExecuteCancelCommand)
			};

			mView.Title = newTeam.Name;
			mView.DataContext = viewModel;
			return mView.ShowDialog() == true ? viewModel.team : null;
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
