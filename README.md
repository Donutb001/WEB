Install-Package Microsoft.EntityFrameworkCore.Tools

Install-Package Microsoft.EntityFrameworkCore.SqlServer
************************************************************************************************** 
 
Scaffold-DbContext "Server=#####;Database=#####;User ID=##;Password=####;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -f
 
builder.Services.AddDbContext<############>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

 
  "ConnectionStrings": {

    "DefaultConnection": "Server=######;Initial Catalog=######;Persist Security Info=False;User ID=#####;Password='####';MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=true;Connection Timeout=30;"

  },
 
