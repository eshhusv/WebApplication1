using WebApplication1;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
string? connection = builder.Configuration.GetConnectionString("DefaultConnection");
IServiceCollection serviceCollection = builder.Services.AddDbContext<ModelDB>(options => options.UseSqlServer(connection));
var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();
app.MapGet("api/Sell", async (ModelDB db) => await db.SellOrders!.ToListAsync());
app.MapGet("api/Sell/{name}", async (ModelDB db, string name) => await db.SellOrders!.Where(u=>u.Name==name).ToListAsync());


app.Run();