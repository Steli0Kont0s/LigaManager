using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
	class WcfHelper
	{
		public static LigaServiceReference.LigaServiceClient client;
		
		public static void Initialize()
		{
			if(client == null)
				client = new LigaServiceReference.LigaServiceClient();
		}
	}
}
