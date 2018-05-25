using System;
using System.Collections.Generic;
using System.Text;

namespace MySportsFeeds.NetCore.Models
{

public class Handedness
{
    public string Bats { get; set; }
    public string Throws { get; set; }
}

public class Draft
{
    public string Year { get; set; }
    public Team team { get; set; }
    public string Round { get; set; }
    public string RoundPick { get; set; }
    public string OverallPick { get; set; }
}

public class ExternalMapping
{
    public string Source { get; set; }
    public string ID { get; set; }
}

public class ActivePlayer
{
    public string ID { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Position { get; set; }
    public string Height { get; set; }
    public string Weight { get; set; }
    public string BirthDate { get; set; }
    public string Age { get; set; }
    public string BirthCity { get; set; }
    public string BirthCountry { get; set; }
    public string IsRookie { get; set; }
    public object HighSchool { get; set; }
    public string College { get; set; }
    public object Twitter { get; set; }
    public string RosterStatus { get; set; }
    public Handedness handedness { get; set; }
    public Draft draft { get; set; }
    public object currentContractYear { get; set; }
    public string officialImageSrc { get; set; }
    public ExternalMapping externalMapping { get; set; }
    public string JerseyNumber { get; set; }
}
    
public class Playerentry
{
    public ActivePlayer player { get; set; }
    public Team2 team { get; set; }
}

public class Activeplayers
{
    public string lastUpdatedOn { get; set; }
    public List<Playerentry> playerentry { get; set; }
}

public class ActivePlayersResponse
{
    public Activeplayers activeplayers { get; set; }
}
}