using Client.Framework;
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
	class MainWindowController
	{
		private List<WcfMatch> SeasonMatches;
		private int MatchDays = 0;
		public MainWindow mView;
		public MainWindowViewModel mViewModel;

		public MainWindowController(WcfBettor bettor)
		{
			mView = new MainWindow();
			mViewModel = new MainWindowViewModel
			{
				Bettor = bettor,
				Seasons = new List<WcfSeason>(),
				MatchDays = new List<MatchDay>(),
				Bet = new WcfBet(),
				Bets = new List<WcfBet>()
			};
			ReloadSeasons();
			
			mView.DataContext = mViewModel;

			mView.ShowDialog();
		}

		private void ReloadSeasons()
		{
			mViewModel.Seasons = WcfHelper.client.GetAllSeasons().ToList();
			mViewModel.SelectedSeason = mViewModel.Seasons.First();
			ReloadMatches();
		}

		private void ReloadMatches()
		{
			if(mViewModel.SelectedSeason != null)
			{
				SeasonMatches = WcfHelper.client.GetMatches(mViewModel.SelectedSeason).ToList();
				MatchDays = SeasonMatches.OrderByDescending(match => match.MatchDay).First().MatchDay;
				ReloadMatchDays();
			}
		}

		private void ReloadMatchDays()
		{
			for(int i = 1; i <= MatchDays; i++)
			{
				mViewModel.MatchDays.Add(new MatchDay(SeasonMatches, i));
			}
		}

		private void ReloadBets()
		{
			mViewModel.Bets = WcfHelper.client.GetBets(mViewModel.Bettor).ToList();
		}
	}
}
