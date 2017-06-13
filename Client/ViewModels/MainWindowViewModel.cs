using Client.Framework;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.ViewModels
{
	class MainWindowViewModel : ViewModelBase
	{
		private ObservableCollection<Bettor> mBettors;
		private Bettor mSelectedBettor;

		public ObservableCollection<Bettor> Bettors
		{
			get { return mBettors; }

			set
			{
				if (mBettors == value)
					return;
				mBettors = value;
				OnPropertyChanged("Bettors");
			}
		}

		public Bettor SelectedBettor
		{
			get { return mSelectedBettor; }

			set
			{
				if (mSelectedBettor == value)
					return;
				mSelectedBettor = value;
				OnPropertyChanged("SelectedBettor");
			}
		}

		public ICommand ButtonAddBettor { get; set; }
		public ICommand ButtonDeleteBettor { get; set; }
		public ICommand ButtonEditBettor { get; set; }


	}
}
