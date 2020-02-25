dotnet restore

<!-- tạo project api .net core   -->

b1. dotnet new webapi -o <nameProject>
cd ./ <nameProject>

b2. add nuget package - dotnet add package Microsoft.EntityFrameworkCore --version 3.1.2 - dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.1.2 - dotnet add package Microsoft.EntityFrameworkCore.Tools --version 3.1.2
b3. tạo foler Models - tạo DBContext.cs , model - tại file appsetting.json add connecString - tại file Startup.cs add
services.AddDbContext<DBContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:SqlConnection"]));

<!-- cài tool migrations : dotnet tool install --global dotnet-ef -->
<!-- và phải cài .NET Core 3.1 vs .NET Framework 4.8 -->

b4. dotnet ef migrations add <name>

<!-- khi update vào database -->

    - dotnet ef database update

<!-- update chỉ định và cập nhật lại  -->

    - dotnet ef database update <name>

<!-- xóa mgrations -->

    dotnet ef migrations remove
