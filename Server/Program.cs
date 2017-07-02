using Server.Framework;
using Server.Models;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Server
{
	class Program
	{
		static void Main(string[] args)
		{
			Database.Initialize("Database\\LigaManager.db3");

			var serviceHost = new ServiceHost(typeof(LigaService));
			serviceHost.Open();

			string[] seperators = {" "};
			string input;
			Boolean running = true;

			while (running)
			{
				input = Console.ReadLine();
				string[] command = input.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

				switch(command[0])
				{
					case "exit":
						running = false;
						break;
				}
			}
		}
	}
}
