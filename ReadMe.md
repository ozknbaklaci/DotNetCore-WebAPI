Help => dotnet -h
New Project Help => dotnet new -h  
New .net core Api Project =>  dotnet new webapi
Installing AutoMapper  => dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection 
Project Run => dotnet run    
Project Watch Run => dotnet watch run
Installing Entity Framework Core  => dotnet add package Microsoft.EntityFrameworkCore.SqlServer
Installing ef dotnet tool => dotnet tool install --global dotnet-ef
Installing Entity Framework Core Design => dotnet add package Microsoft.EntityFrameworkCore.Design
Check tools Entity Framework  => dotnet ef
Ef Help => dotnet ef -h
First Migrations InitialCreate =>  dotnet ef migrations add InitialCreate
Database Update and Create DataContext Table => dotnet ef database update
Add New Table Migrations => dotnet ef migrations add User  ==> Database Update Table => dotnet ef database update
Relation Migration => dotnet ef migrations add UserCharacterRelation
Identity Models Tokens => dotnet add package Microsoft.IdentityModel.Tokens --version 6.7.1
Identity Model Tokens Jwt => dotnet add package System.IdentityModel.Tokens.Jwt --version 6.7.1
Microsoft AspNetCore Authentication JwtBearer => dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 3.1.8

Weapon Migration => dotnet ef migrations add Weapon (Error!! => The child/dependent side could not be determined for the one-to-one relationship between 'Character.Weapon' and 'Weapon.Character'. To identify the child/dependent side of the relationship, configure the foreign key property. If these navigations should not be part of the same relationship configure them without specifying the inverse. See http://go.microsoft.com/fwlink/?LinkId=724062 for more details.) Adding Model CharacterId property. 
Add New Table Migrations => dotnet ef migrations add Weapon =>after ==> Database Update Table => dotnet ef database update

Add New Table Migrations => dotnet ef migrations add Skill =>after ==> Database Update Table => dotnet ef database update


