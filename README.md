```sh
dotnet tool install -g dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet run
```

for Migrating the server, use this command

```sh
dotnet ef migrations add Initial
dotnet ef database update -c ProductDbContext
```
