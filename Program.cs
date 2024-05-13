
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

var client = new HttpClient();

string yourapikey = "babababa";
//HttpResponseMessage response = await client.GetAsync("https://api.sportsdata.io/v4/soccer/scores/json/Competitions?key={yourapikey}");

// if(response.IsSuccessStatusCode){

//     var result = await response.Content.ReadAsStringAsync();
//     var obj = JsonSerializer.Deserialize<List<Competition>>(result);

//     foreach(var item in obj){
//        Console.Write($"id:{ item.CompetitionId } | {item.Name} \n " );
       
//     }

    
// }

// var response = await client.GetStringAsync("https://api.sportsdata.io/v4/soccer/scores/json/Teams/1?key={yourapikey}");

// var result = JsonSerializer.Deserialize<List<Team>>(response);
// foreach(var item in result){
// Console.Write($"{item.TeamId}|{item.Name}|{item.City}|{item.Nickname1}\n");
// }

// var response = await client.GetStringAsync("https://api.sportsdata.io/v4/soccer/scores/json/PlayersByTeam/1/516?key={yourapikey}");
// var result = JsonSerializer.Deserialize<List<Player>>(response);
// foreach(var item in result){
// Console.Write($"{item.CommonName} | {item.Jersey} \n");
// }



// var response = await client.GetStringAsync("https://api.sportsdata.io/v4/soccer/scores/json/CompetitionDetails/1?key={yourapikey}");
// var result = JsonSerializer.Deserialize<Root>(response);

// foreach(var item in result.Games){

//     if((item.HomeTeamId==516 || item.AwayTeamId==516) && item.DateTime > DateTime.UtcNow){

//     Console.Write($"{item.HomeTeamName} vs {item.AwayTeamName} | {item.DateTime}\n");

//     }

// }
string[] obj = {"EPL","WNBA"};

// Console.WriteLine("Welcome! to sportfocus");
// Thread.Sleep(2000);
// Console.Clear();
Console.WriteLine("Pick a League");

for(int i = 0; i < obj.Length;i++){
    Console.WriteLine(obj[i]);
}
var a = readkey();
Console.Clear();
Console.WriteLine(a);
Thread.Sleep(1000);
Console.Clear();


var response = await client.GetStringAsync($"https://api.sportsdata.io/v4/soccer/scores/json/Teams/{a}?key={yourapikey}");

var result = JsonSerializer.Deserialize<List<Team>>(response);

var y = result.Count();
for(int z=0; z<y ; z++){

Console.Write($" {result[z].TeamId} | {result[z].Name}\n");
}

var b = readkey();

var id = result[b].TeamId;


var response1 = await client.GetStringAsync($"https://api.sportsdata.io/v4/soccer/scores/json/PlayersByTeam/1/{id}?key={yourapikey}");
var result1 = JsonSerializer.Deserialize<List<Player>>(response1);
foreach(var item in result1){
    Console.Write(item.CommonName+"\n");
}
//result1.Teams[0].Players.Count();







int readkey(){

    var hello = Console.ReadKey(true).KeyChar;
    
 
    if(hello != 'y'){

    if(hello =='w'){
        var yo = Console.GetCursorPosition();
        Console.SetCursorPosition(yo.Left,yo.Top-1);
        readkey();}
    if(hello =='s'){
        var yo = Console.GetCursorPosition();
        Console.SetCursorPosition(yo.Left,yo.Top+1);
        readkey();}
    }

    var loca = Console.GetCursorPosition();
    return loca.Top;  
}


    public class CurrentSeason
    {
        public int? SeasonId { get; set; }
        public int? CompetitionId { get; set; }
        public int? Season { get; set; }
        public string Name { get; set; }
        public string CompetitionName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool currentSeason { get; set; }
        public List<Round>? Rounds { get; set; }
    }

    public class Game
    {
        public int? GameId { get; set; }
        public int? RoundId { get; set; }
        public int? Season { get; set; }
        public int? SeasonType { get; set; }
        public object Group { get; set; }
        public int? AwayTeamId { get; set; }
        public int? HomeTeamId { get; set; }
        public int? VenueId { get; set; }
        public DateTime Day { get; set; }
        public DateTime DateTime { get; set; }
        public string Status { get; set; }
        public int? Week { get; set; }
        public string Period { get; set; }
        public object Clock { get; set; }
        public string Winner { get; set; }
        public string VenueType { get; set; }
        public string AwayTeamKey { get; set; }
        public string AwayTeamName { get; set; }
        public string AwayTeamCountryCode { get; set; }
        public int? AwayTeamScore { get; set; }
        public int? AwayTeamScorePeriod1 { get; set; }
        public int? AwayTeamScorePeriod2 { get; set; }
        public object AwayTeamScoreExtraTime { get; set; }
        public object AwayTeamScorePenalty { get; set; }
        public string HomeTeamKey { get; set; }
        public string HomeTeamName { get; set; }
        public string HomeTeamCountryCode { get; set; }
        public int? HomeTeamScore { get; set; }
        public int? HomeTeamScorePeriod1 { get; set; }
        public int? HomeTeamScorePeriod2 { get; set; }
        public object HomeTeamScoreExtraTime { get; set; }
        public object HomeTeamScorePenalty { get; set; }
        public int? HomeTeamMoneyLine { get; set; }
        public int? AwayTeamMoneyLine { get; set; }
        public int? DrawMoneyLine { get; set; }
        public double PointSpread { get; set; }
        public int? HomeTeamPointSpreadPayout { get; set; }
        public int? AwayTeamPointSpreadPayout { get; set; }
        public double OverUnder { get; set; }
        public int? OverPayout { get; set; }
        public int? UnderPayout { get; set; }
        public int? Attendance { get; set; }
        public DateTime Updated { get; set; }
        public DateTime UpdatedUtc { get; set; }
        public int? GlobalGameId { get; set; }
        public int? GlobalAwayTeamId { get; set; }
        public int? GlobalHomeTeamId { get; set; }
        public object ClockExtra { get; set; }
        public string ClockDisplay { get; set; }
        public bool IsClosed { get; set; }
        public string HomeTeamFormation { get; set; }
        public string AwayTeamFormation { get; set; }
        public object PlayoffAggregateScore { get; set; }
    }

    public class Player
    {
        public int? PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CommonName { get; set; }
        public string ShortName { get; set; }
        public string Position { get; set; }
        public string PositionCategory { get; set; }
        public int? Jersey { get; set; }
        public string Foot { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public string Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthCity { get; set; }
        public string BirthCountry { get; set; }
        public string Nationality { get; set; }
        public string InjuryStatus { get; set; }
        public string InjuryBodyPart { get; set; }
        public string InjuryNotes { get; set; }
        public DateTime? InjuryStartDate { get; set; }
        public DateTime Updated { get; set; }
        public string PhotoUrl { get; set; }
        public int? RotoWirePlayerID { get; set; }
        public string DraftKingsPosition { get; set; }
        public int? UsaTodayPlayerID { get; set; }
        public string UsaTodayHeadshotUrl { get; set; }
        public string UsaTodayHeadshotNoBackgroundUrl { get; set; }
        public DateTime? UsaTodayHeadshotUpdated { get; set; }
        public DateTime? UsaTodayHeadshotNoBackgroundUpdated { get; set; }
    }

    public class Root
    {
        public int? CompetitionId { get; set; }
        public int? AreaId { get; set; }
        public string AreaName { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }
        public string Format { get; set; }
        public string Key { get; set; }
        public CurrentSeason CurrentSeason { get; set; }
        public List<Team> Teams { get; set; }
        public List<Game> Games { get; set; }
        public List<Season> Seasons { get; set; }
    }

    public class Round
    {
        public int? RoundId { get; set; }
        public int? SeasonId { get; set; }
        public int? Season { get; set; }
        public int? SeasonType { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? CurrentWeek { get; set; }
        public bool CurrentRound { get; set; }
        public List<Game> Games { get; set; }
        public List<object> Standings { get; set; }
        public List<object> TeamSeasons { get; set; }
        public List<object> PlayerSeasons { get; set; }
    }

    public class Season
    {
        public int? SeasonId { get; set; }
        public int? CompetitionId { get; set; }
        public int? season { get; set; }
        public string Name { get; set; }
        public string CompetitionName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool CurrentSeason { get; set; }
        public List<Round> Rounds { get; set; }
    }

    public class Team
    {
        public int? TeamId { get; set; }
        public int? AreaId { get; set; }
        public int? VenueId { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public bool Active { get; set; }
        public string AreaName { get; set; }
        public string VenueName { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public int? Founded { get; set; }
        public string ClubColor1 { get; set; }
        public string ClubColor2 { get; set; }
        public string ClubColor3 { get; set; }
        public string Nickname1 { get; set; }
        public string Nickname2 { get; set; }
        public string Nickname3 { get; set; }
        public string WikipediaLogoUrl { get; set; }
        public string WikipediaWordMarkUrl { get; set; }
        public int? GlobalTeamId { get; set; }
        public List<Player> Players { get; set; }
    }

public class Competition
{
    public int? CompetitionId { get; set; }
    public int? AreaId { get; set; }
    public string AreaName { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Type { get; set; }
    public string Format { get; set; }
    public string Key { get; set; }
    public List<Season> Seasons { get; set; }
}
