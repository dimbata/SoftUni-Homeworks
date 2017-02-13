namespace Teamwork_Projects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            /*
             * It's time for teamwork projects and you are responsible for making the teams. 
             * First you will receive an integer - the count of the teams you will have to register. 
             * You will be given a user and a team (separated with "-").  
             * The user is the creator of that team. 
             * For every newly created team you should print a message:
             *  "Team {team Name} has been created by {user}!". 
             *  Next you will receive user with team (separated with "->") 
             *  which means that the user wants to join that team. 
             *  Upon receiving command: "end of assignment" you should print every team
             *  ordered by members count (descending) and then by name (ascending).
             *   For each team you have to print it's members sorted by name (ascending).
             *    However there are several rules:
                    •	If user tries to create a team more than once a message should be displayed: 
                    -	"Team {teamName} was already created!"

                    •	Creator of a team cannot create another team - message should be thrown: 
                    -	"{user} cannot create another team!"

                    •	If user tries to join currently non-existing team a message should be displayed: 
                    -	"Team {teamName} does not exist!"

                    •	Member of a team cannot join another team - message should be thrown:
                    -	"Member {user} cannot join team {team Name}!"

                    •	In the end (after teams' report) teams with zero members (with only a creator) should disband.
                    Every team to disband should be printed ordered by name (ascending) in this format:
                    - {teamName}:
                    - {creator}
                    -- {member}…
             */

            int teamsToRegister = int.Parse(Console.ReadLine());
            var teams = new List<Team>();

            for (int i = 0; i < teamsToRegister; i++)
            {
                var inputData = Console.ReadLine().Split('-');
                string creator = inputData[0];
                string teamName = inputData[1];

                if (teams.Select(j => j.Name).Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Select(j => j.Creator).Contains(creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                var currentTeam = new Team()
                {
                    Creator = creator,
                    Name = teamName
                };

                teams.Add(currentTeam);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            while (true)
            {
                var movementsBetweenTeams = Console.ReadLine()
                    .Split(new char[] { '-', '>' },
                    StringSplitOptions.RemoveEmptyEntries);

                if (movementsBetweenTeams[0] == "end of assignment")
                {
                    break;
                }

                string userName = movementsBetweenTeams[0];
                string team = movementsBetweenTeams[1];

                if (!teams.Select(i => i.Name).Contains(team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    continue;
                }

                if (teams.Select(i => i.Creator).Contains(userName) || teams.SelectMany(i => i.Members).Contains(userName))
                {
                    Console.WriteLine($"Member {userName} cannot join team {team}!");
                    continue;
                }

                foreach (var item in teams)
                {
                    if (item.Name == team && item.Creator != userName)
                    {
                        item.Members.Add(userName);
                    }
                }
            }

            var toBeDisbanded = teams.OrderBy(i => i.Members.Count).TakeWhile(i => i.Members.Count == 0);


            foreach (var team in teams.OrderByDescending(i => i.Members.Count).ThenBy(i => i.Name))
            {
                if (team.Members.Count == 0)
                {
                    continue;
                }

                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(i => i))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");


            foreach (var team in toBeDisbanded.OrderBy(n => n.Name))
            {
                Console.WriteLine(team.Name);
            }

        }
    }
}
