using Client.Framework;
using Client.ViewModels;
using Client.Views;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controller
{
	class MainWindowController
	{
		private MainWindowViewModel mViewModel;
		public void Initialize()
		{
			var view = new MainWindow();
			mViewModel = new MainWindowViewModel
			{
				Bettors = new ObservableCollection<Bettor>(),
				ButtonAddBettor = new RelayCommand(AddCommandExecute),
				ButtonDeleteBettor = new RelayCommand(DeleteCommandExecute, DeleteCommandCanExecute)
			};
			view.DataContext = mViewModel;

			LigaServiceReference.LigaServiceClient client = new LigaServiceReference.LigaServiceClient();
			mViewModel.Bettors.Add(client.GetBettorById(1));

			view.ShowDialog();
		}

		private void AddCommandExecute(object obj)
		{
			var addedObject = new WindowAddController().AddBettor();
			if(addedObject != null)
			{
				mViewModel.Bettors.Add(addedObject);
			}
		}

		private void DeleteCommandExecute(object obj)
		{
			if (mViewModel.SelectedBettor != null)
			{
				if(mViewModel.SelectedBettor.Bets.Count() == 0)
				{
					mViewModel.Bettors.Remove(mViewModel.SelectedBettor);
				}
				else
				{
					// Bettor kann nicht gelöscht werden, da er noch bets besitzt
				}
				
			}
				
		}

		private bool DeleteCommandCanExecute(object obj)
		{
			return mViewModel.SelectedBettor != null;
		}
	}
}
