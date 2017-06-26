using Client.Framework;
using Server.WcfModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TippspielClient.ViewModels
{
	class UserPanelViewModel : ViewModelBase
	{
		public WcfBettor Bettor { get; set; }

		public string FirstName
		{
			get
			{
				return Bettor.Firstname;
			}

			set
			{
				Bettor.Firstname = value;
			}
		}

		public string LastName
		{
			get
			{
				return Bettor.Lastname;
			}

			set
			{
				Bettor.Lastname = value;
			}
		}

		public string NickName
		{
			get
			{
				return Bettor.Nickname;
			}

			set
			{
				Bettor.Nickname = value;
			}
		}
	}
}
