﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.LigaServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LigaServiceReference.ILigaService")]
    public interface ILigaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/Test", ReplyAction="http://tempuri.org/ILigaService/TestResponse")]
        string Test([System.ServiceModel.MessageParameterAttribute(Name="Test")] string Test1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/Test", ReplyAction="http://tempuri.org/ILigaService/TestResponse")]
        System.Threading.Tasks.Task<string> TestAsync(string Test);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/GetBettors", ReplyAction="http://tempuri.org/ILigaService/GetBettorsResponse")]
        System.Collections.ObjectModel.Collection<Server.Models.Bettor> GetBettors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/GetBettors", ReplyAction="http://tempuri.org/ILigaService/GetBettorsResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.Collection<Server.Models.Bettor>> GetBettorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/GetBettorById", ReplyAction="http://tempuri.org/ILigaService/GetBettorByIdResponse")]
        Server.Models.Bettor GetBettorById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/GetBettorById", ReplyAction="http://tempuri.org/ILigaService/GetBettorByIdResponse")]
        System.Threading.Tasks.Task<Server.Models.Bettor> GetBettorByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/AddBettor", ReplyAction="http://tempuri.org/ILigaService/AddBettorResponse")]
        void AddBettor(string firstName, string lastName, string nickName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/AddBettor", ReplyAction="http://tempuri.org/ILigaService/AddBettorResponse")]
        System.Threading.Tasks.Task AddBettorAsync(string firstName, string lastName, string nickName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/EditBettor", ReplyAction="http://tempuri.org/ILigaService/EditBettorResponse")]
        void EditBettor(Server.Models.Bettor bettor, string firstName, string lastName, string nickName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/EditBettor", ReplyAction="http://tempuri.org/ILigaService/EditBettorResponse")]
        System.Threading.Tasks.Task EditBettorAsync(Server.Models.Bettor bettor, string firstName, string lastName, string nickName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/DeleteBettor", ReplyAction="http://tempuri.org/ILigaService/DeleteBettorResponse")]
        void DeleteBettor(Server.Models.Bettor bettor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/DeleteBettor", ReplyAction="http://tempuri.org/ILigaService/DeleteBettorResponse")]
        System.Threading.Tasks.Task DeleteBettorAsync(Server.Models.Bettor bettor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/GetTeams", ReplyAction="http://tempuri.org/ILigaService/GetTeamsResponse")]
        System.Collections.ObjectModel.Collection<Server.Models.Team> GetTeams();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/GetTeams", ReplyAction="http://tempuri.org/ILigaService/GetTeamsResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.Collection<Server.Models.Team>> GetTeamsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/GetTeamById", ReplyAction="http://tempuri.org/ILigaService/GetTeamByIdResponse")]
        Server.Models.Team GetTeamById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/GetTeamById", ReplyAction="http://tempuri.org/ILigaService/GetTeamByIdResponse")]
        System.Threading.Tasks.Task<Server.Models.Team> GetTeamByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/AddTeam", ReplyAction="http://tempuri.org/ILigaService/AddTeamResponse")]
        void AddTeam(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/AddTeam", ReplyAction="http://tempuri.org/ILigaService/AddTeamResponse")]
        System.Threading.Tasks.Task AddTeamAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/EditTeam", ReplyAction="http://tempuri.org/ILigaService/EditTeamResponse")]
        void EditTeam(Server.Models.Team team, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/EditTeam", ReplyAction="http://tempuri.org/ILigaService/EditTeamResponse")]
        System.Threading.Tasks.Task EditTeamAsync(Server.Models.Team team, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/DeleteTeam", ReplyAction="http://tempuri.org/ILigaService/DeleteTeamResponse")]
        void DeleteTeam(Server.Models.Team team);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/DeleteTeam", ReplyAction="http://tempuri.org/ILigaService/DeleteTeamResponse")]
        System.Threading.Tasks.Task DeleteTeamAsync(Server.Models.Team team);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/GetMatches", ReplyAction="http://tempuri.org/ILigaService/GetMatchesResponse")]
        System.Collections.ObjectModel.Collection<Server.Models.Match> GetMatches();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/GetMatches", ReplyAction="http://tempuri.org/ILigaService/GetMatchesResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.Collection<Server.Models.Match>> GetMatchesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/GetMatchById", ReplyAction="http://tempuri.org/ILigaService/GetMatchByIdResponse")]
        Server.Models.Match GetMatchById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/GetMatchById", ReplyAction="http://tempuri.org/ILigaService/GetMatchByIdResponse")]
        System.Threading.Tasks.Task<Server.Models.Match> GetMatchByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/AddMatch", ReplyAction="http://tempuri.org/ILigaService/AddMatchResponse")]
        void AddMatch(Server.Models.Season season, Server.Models.Team homeTeam, Server.Models.Team awayTeam, int homeTeamScore, int awayTeamScore, System.DateTime dateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/AddMatch", ReplyAction="http://tempuri.org/ILigaService/AddMatchResponse")]
        System.Threading.Tasks.Task AddMatchAsync(Server.Models.Season season, Server.Models.Team homeTeam, Server.Models.Team awayTeam, int homeTeamScore, int awayTeamScore, System.DateTime dateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/EditMatch", ReplyAction="http://tempuri.org/ILigaService/EditMatchResponse")]
        void EditMatch(Server.Models.Match match, int homeTeamScore, int awayTeamScore, System.DateTime dateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/EditMatch", ReplyAction="http://tempuri.org/ILigaService/EditMatchResponse")]
        System.Threading.Tasks.Task EditMatchAsync(Server.Models.Match match, int homeTeamScore, int awayTeamScore, System.DateTime dateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/DeleteMatch", ReplyAction="http://tempuri.org/ILigaService/DeleteMatchResponse")]
        void DeleteMatch(Server.Models.Match match);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/DeleteMatch", ReplyAction="http://tempuri.org/ILigaService/DeleteMatchResponse")]
        System.Threading.Tasks.Task DeleteMatchAsync(Server.Models.Match match);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/GetSeasons", ReplyAction="http://tempuri.org/ILigaService/GetSeasonsResponse")]
        System.Collections.ObjectModel.Collection<Server.Models.Season> GetSeasons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/GetSeasons", ReplyAction="http://tempuri.org/ILigaService/GetSeasonsResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.Collection<Server.Models.Season>> GetSeasonsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/GetSeasonById", ReplyAction="http://tempuri.org/ILigaService/GetSeasonByIdResponse")]
        Server.Models.Season GetSeasonById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/GetSeasonById", ReplyAction="http://tempuri.org/ILigaService/GetSeasonByIdResponse")]
        System.Threading.Tasks.Task<Server.Models.Season> GetSeasonByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/AddSeason", ReplyAction="http://tempuri.org/ILigaService/AddSeasonResponse")]
        void AddSeason(string name, string description, System.DateTime dateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/AddSeason", ReplyAction="http://tempuri.org/ILigaService/AddSeasonResponse")]
        System.Threading.Tasks.Task AddSeasonAsync(string name, string description, System.DateTime dateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/EditSeason", ReplyAction="http://tempuri.org/ILigaService/EditSeasonResponse")]
        void EditSeason(Server.Models.Season season, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/EditSeason", ReplyAction="http://tempuri.org/ILigaService/EditSeasonResponse")]
        System.Threading.Tasks.Task EditSeasonAsync(Server.Models.Season season, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/DeleteSeason", ReplyAction="http://tempuri.org/ILigaService/DeleteSeasonResponse")]
        void DeleteSeason(Server.Models.Season season);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/DeleteSeason", ReplyAction="http://tempuri.org/ILigaService/DeleteSeasonResponse")]
        System.Threading.Tasks.Task DeleteSeasonAsync(Server.Models.Season season);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/GetBets", ReplyAction="http://tempuri.org/ILigaService/GetBetsResponse")]
        System.Collections.ObjectModel.Collection<Server.Models.Bet> GetBets();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/GetBets", ReplyAction="http://tempuri.org/ILigaService/GetBetsResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.Collection<Server.Models.Bet>> GetBetsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/GetBetById", ReplyAction="http://tempuri.org/ILigaService/GetBetByIdResponse")]
        Server.Models.Bet GetBetById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/GetBetById", ReplyAction="http://tempuri.org/ILigaService/GetBetByIdResponse")]
        System.Threading.Tasks.Task<Server.Models.Bet> GetBetByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/AddBet", ReplyAction="http://tempuri.org/ILigaService/AddBetResponse")]
        void AddBet(Server.Models.Bettor bettor, Server.Models.Match match, int homeTeamScore, int awayTeamScore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/AddBet", ReplyAction="http://tempuri.org/ILigaService/AddBetResponse")]
        System.Threading.Tasks.Task AddBetAsync(Server.Models.Bettor bettor, Server.Models.Match match, int homeTeamScore, int awayTeamScore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/EditBet", ReplyAction="http://tempuri.org/ILigaService/EditBetResponse")]
        void EditBet(Server.Models.Bet bet, int homeTeamScore, int awayTeamScore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/EditBet", ReplyAction="http://tempuri.org/ILigaService/EditBetResponse")]
        System.Threading.Tasks.Task EditBetAsync(Server.Models.Bet bet, int homeTeamScore, int awayTeamScore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/DeleteBet", ReplyAction="http://tempuri.org/ILigaService/DeleteBetResponse")]
        void DeleteBet(Server.Models.Bet bet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILigaService/DeleteBet", ReplyAction="http://tempuri.org/ILigaService/DeleteBetResponse")]
        System.Threading.Tasks.Task DeleteBetAsync(Server.Models.Bet bet);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILigaServiceChannel : Client.LigaServiceReference.ILigaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LigaServiceClient : System.ServiceModel.ClientBase<Client.LigaServiceReference.ILigaService>, Client.LigaServiceReference.ILigaService {
        
        public LigaServiceClient() {
        }
        
        public LigaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LigaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LigaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LigaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Test(string Test1) {
            return base.Channel.Test(Test1);
        }
        
        public System.Threading.Tasks.Task<string> TestAsync(string Test) {
            return base.Channel.TestAsync(Test);
        }
        
        public System.Collections.ObjectModel.Collection<Server.Models.Bettor> GetBettors() {
            return base.Channel.GetBettors();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.Collection<Server.Models.Bettor>> GetBettorsAsync() {
            return base.Channel.GetBettorsAsync();
        }
        
        public Server.Models.Bettor GetBettorById(int id) {
            return base.Channel.GetBettorById(id);
        }
        
        public System.Threading.Tasks.Task<Server.Models.Bettor> GetBettorByIdAsync(int id) {
            return base.Channel.GetBettorByIdAsync(id);
        }
        
        public void AddBettor(string firstName, string lastName, string nickName) {
            base.Channel.AddBettor(firstName, lastName, nickName);
        }
        
        public System.Threading.Tasks.Task AddBettorAsync(string firstName, string lastName, string nickName) {
            return base.Channel.AddBettorAsync(firstName, lastName, nickName);
        }
        
        public void EditBettor(Server.Models.Bettor bettor, string firstName, string lastName, string nickName) {
            base.Channel.EditBettor(bettor, firstName, lastName, nickName);
        }
        
        public System.Threading.Tasks.Task EditBettorAsync(Server.Models.Bettor bettor, string firstName, string lastName, string nickName) {
            return base.Channel.EditBettorAsync(bettor, firstName, lastName, nickName);
        }
        
        public void DeleteBettor(Server.Models.Bettor bettor) {
            base.Channel.DeleteBettor(bettor);
        }
        
        public System.Threading.Tasks.Task DeleteBettorAsync(Server.Models.Bettor bettor) {
            return base.Channel.DeleteBettorAsync(bettor);
        }
        
        public System.Collections.ObjectModel.Collection<Server.Models.Team> GetTeams() {
            return base.Channel.GetTeams();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.Collection<Server.Models.Team>> GetTeamsAsync() {
            return base.Channel.GetTeamsAsync();
        }
        
        public Server.Models.Team GetTeamById(int id) {
            return base.Channel.GetTeamById(id);
        }
        
        public System.Threading.Tasks.Task<Server.Models.Team> GetTeamByIdAsync(int id) {
            return base.Channel.GetTeamByIdAsync(id);
        }
        
        public void AddTeam(string name) {
            base.Channel.AddTeam(name);
        }
        
        public System.Threading.Tasks.Task AddTeamAsync(string name) {
            return base.Channel.AddTeamAsync(name);
        }
        
        public void EditTeam(Server.Models.Team team, string name) {
            base.Channel.EditTeam(team, name);
        }
        
        public System.Threading.Tasks.Task EditTeamAsync(Server.Models.Team team, string name) {
            return base.Channel.EditTeamAsync(team, name);
        }
        
        public void DeleteTeam(Server.Models.Team team) {
            base.Channel.DeleteTeam(team);
        }
        
        public System.Threading.Tasks.Task DeleteTeamAsync(Server.Models.Team team) {
            return base.Channel.DeleteTeamAsync(team);
        }
        
        public System.Collections.ObjectModel.Collection<Server.Models.Match> GetMatches() {
            return base.Channel.GetMatches();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.Collection<Server.Models.Match>> GetMatchesAsync() {
            return base.Channel.GetMatchesAsync();
        }
        
        public Server.Models.Match GetMatchById(int id) {
            return base.Channel.GetMatchById(id);
        }
        
        public System.Threading.Tasks.Task<Server.Models.Match> GetMatchByIdAsync(int id) {
            return base.Channel.GetMatchByIdAsync(id);
        }
        
        public void AddMatch(Server.Models.Season season, Server.Models.Team homeTeam, Server.Models.Team awayTeam, int homeTeamScore, int awayTeamScore, System.DateTime dateTime) {
            base.Channel.AddMatch(season, homeTeam, awayTeam, homeTeamScore, awayTeamScore, dateTime);
        }
        
        public System.Threading.Tasks.Task AddMatchAsync(Server.Models.Season season, Server.Models.Team homeTeam, Server.Models.Team awayTeam, int homeTeamScore, int awayTeamScore, System.DateTime dateTime) {
            return base.Channel.AddMatchAsync(season, homeTeam, awayTeam, homeTeamScore, awayTeamScore, dateTime);
        }
        
        public void EditMatch(Server.Models.Match match, int homeTeamScore, int awayTeamScore, System.DateTime dateTime) {
            base.Channel.EditMatch(match, homeTeamScore, awayTeamScore, dateTime);
        }
        
        public System.Threading.Tasks.Task EditMatchAsync(Server.Models.Match match, int homeTeamScore, int awayTeamScore, System.DateTime dateTime) {
            return base.Channel.EditMatchAsync(match, homeTeamScore, awayTeamScore, dateTime);
        }
        
        public void DeleteMatch(Server.Models.Match match) {
            base.Channel.DeleteMatch(match);
        }
        
        public System.Threading.Tasks.Task DeleteMatchAsync(Server.Models.Match match) {
            return base.Channel.DeleteMatchAsync(match);
        }
        
        public System.Collections.ObjectModel.Collection<Server.Models.Season> GetSeasons() {
            return base.Channel.GetSeasons();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.Collection<Server.Models.Season>> GetSeasonsAsync() {
            return base.Channel.GetSeasonsAsync();
        }
        
        public Server.Models.Season GetSeasonById(int id) {
            return base.Channel.GetSeasonById(id);
        }
        
        public System.Threading.Tasks.Task<Server.Models.Season> GetSeasonByIdAsync(int id) {
            return base.Channel.GetSeasonByIdAsync(id);
        }
        
        public void AddSeason(string name, string description, System.DateTime dateTime) {
            base.Channel.AddSeason(name, description, dateTime);
        }
        
        public System.Threading.Tasks.Task AddSeasonAsync(string name, string description, System.DateTime dateTime) {
            return base.Channel.AddSeasonAsync(name, description, dateTime);
        }
        
        public void EditSeason(Server.Models.Season season, string name) {
            base.Channel.EditSeason(season, name);
        }
        
        public System.Threading.Tasks.Task EditSeasonAsync(Server.Models.Season season, string name) {
            return base.Channel.EditSeasonAsync(season, name);
        }
        
        public void DeleteSeason(Server.Models.Season season) {
            base.Channel.DeleteSeason(season);
        }
        
        public System.Threading.Tasks.Task DeleteSeasonAsync(Server.Models.Season season) {
            return base.Channel.DeleteSeasonAsync(season);
        }
        
        public System.Collections.ObjectModel.Collection<Server.Models.Bet> GetBets() {
            return base.Channel.GetBets();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.Collection<Server.Models.Bet>> GetBetsAsync() {
            return base.Channel.GetBetsAsync();
        }
        
        public Server.Models.Bet GetBetById(int id) {
            return base.Channel.GetBetById(id);
        }
        
        public System.Threading.Tasks.Task<Server.Models.Bet> GetBetByIdAsync(int id) {
            return base.Channel.GetBetByIdAsync(id);
        }
        
        public void AddBet(Server.Models.Bettor bettor, Server.Models.Match match, int homeTeamScore, int awayTeamScore) {
            base.Channel.AddBet(bettor, match, homeTeamScore, awayTeamScore);
        }
        
        public System.Threading.Tasks.Task AddBetAsync(Server.Models.Bettor bettor, Server.Models.Match match, int homeTeamScore, int awayTeamScore) {
            return base.Channel.AddBetAsync(bettor, match, homeTeamScore, awayTeamScore);
        }
        
        public void EditBet(Server.Models.Bet bet, int homeTeamScore, int awayTeamScore) {
            base.Channel.EditBet(bet, homeTeamScore, awayTeamScore);
        }
        
        public System.Threading.Tasks.Task EditBetAsync(Server.Models.Bet bet, int homeTeamScore, int awayTeamScore) {
            return base.Channel.EditBetAsync(bet, homeTeamScore, awayTeamScore);
        }
        
        public void DeleteBet(Server.Models.Bet bet) {
            base.Channel.DeleteBet(bet);
        }
        
        public System.Threading.Tasks.Task DeleteBetAsync(Server.Models.Bet bet) {
            return base.Channel.DeleteBetAsync(bet);
        }
    }
}