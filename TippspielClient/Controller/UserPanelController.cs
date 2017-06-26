using Server.WcfModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TippspielClient.ViewModels;
using TippspielClient.Views;

namespace TippspielClient.Controller
{
	class UserPanelController
	{
		public UserPanel mView;
		public UserPanelViewModel mViewModel;

		public UserPanelController(WcfBettor bettor)
		{
			mView = new UserPanel();
			mViewModel = new UserPanelViewModel
			{
				Bettor = bettor
			};

			mView.DataContext = mViewModel;

			mView.ShowDialog();
		}
	}
}
