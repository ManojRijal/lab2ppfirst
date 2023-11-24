type Coach = {
    Name: string
    formerPlayer: bool
}

type Stats = {
    wins: int
    losses: int
}

type Team = {
    Name: string
    coach: Coach
    Stats: Stats
}
let teams = [
    { Name = "Cleveland Cavaliers"; coach = { Name = "J.B. Bickerstaff"; formerPlayer = false }; Stats = { wins = 1984; losses = 2287 } };
    { Name = "Dallas Mavericks"; coach = { Name = "Jason Kidd"; formerPlayer = true }; Stats = { wins = 1747; losses = 1714 } };
    { Name = "Denver Nuggets"; coach = { Name = "Michael Malone"; formerPlayer = false }; Stats = { wins = 1897; losses = 1890 } };
    { Name = "New York Knicks"; coach = { Name = "Tom Thibodeau"; formerPlayer = false }; Stats = { wins = 2924; losses = 3099 } };
    { Name = "Orlando Magic"; coach = { Name = "Jamahl Mosley"; formerPlayer = false }; Stats = { wins = 1268; losses = 1453 } };
]



let bestTeams = teams |> List.filter (fun team -> team.Stats.wins > team.Stats.losses)

bestTeams |> List.iter (fun team -> printfn "Team Name: %s" team.Name)
bestTeams |> List.iter (fun team -> printfn "Team Wins: %d" team.Stats.wins)

let calculateSuccessPercentage team =
    float team.Stats.wins / float (team.Stats.wins + team.Stats.losses) * 100.0

let successPercentages = bestTeams |> List.map calculateSuccessPercentage
let avg = List.average successPercentages

printfn "The percentage of the team is %f" avg
