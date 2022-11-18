# Character-Helper

This project is a tool to assist with tabletop games. 
It allows the user to view characters and players that are saved to a database and add more players and characters.

This project features 3 unit tests, 
regular expressions for validation of phone numbers (found in Views/Player/Create.cshtml), 
and comments explaining how I am using Solid principles (found in Views/Home/Index.cshtml and Models/CharacterViewModel.cs)

Instructions
------------
Requires NuGets:
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools

Uses visual studio's built in SQL Server
The Migrations are ready, you just need to update-database in the Pakage Manager Console to build the tables.
You will need to create a player before you can create a character as all characters need a player.
