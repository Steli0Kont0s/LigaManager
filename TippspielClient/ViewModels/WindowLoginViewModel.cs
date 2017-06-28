using Client.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TippspielClient.ViewModels
{
	class WindowLoginViewModel : ViewModelBase
	{
		public ICommand LoginCommand { get; set; }
		public string UserName { get; set; }
	}
}
