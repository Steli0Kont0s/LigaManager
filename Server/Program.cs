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

					case "list":
						
						if(command.Length == 2)
						{
							switch(command[1])
							{
								case "bets":
									Commands.List.Bets();
									break;

								case "bettors":
									Commands.List.Bettors();
									break;

								case "matches":
									Commands.List.Matches();
									break;

								case "seasons":
									Commands.List.Seasons();
									break;

								case "teams":
									Commands.List.Teams();
									break;
							}
						}
						break;

					case "delete":

						if (command.Length == 3)
						{
							switch (command[1])
							{
								case "bet":
									Commands.Delete.Bet(command[2]);
									break;

								case "bettor":
									Commands.Delete.Bettor(command[2]);
									break;

								case "satche":
									Commands.Delete.Match(command[2]);
									break;

								case "season":
									Commands.Delete.Season(command[2]);
									break;

								case "team":
									Commands.Delete.Team(command[2]);
									break;

								case "relation":
									Commands.Delete.SeasonsToTeamsRelation(command[2]);
									break;
							}
						}
						break;
				}
			}
		}
	}
}
