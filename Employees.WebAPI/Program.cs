using Employees.WebAPI.AppConfiguration.ServicesExtensions;
using Employees.WebAPI.AppConfiguration.ApplicationExtensions;
using Serilog;

var configuration = new ConfigurationBuilder()
.AddJsonFile("appsettings.json", optional: false)
.Build();

var builder = WebApplication.CreateBuilder(args);


builder.AddSerilogConfiguration();
builder.Services.AddDbContextConfiguration(configuration);
//builder.Services.AddMapperConfiguration();
builder.Services.AddVersioningConfiguration();
builder.Services.AddControllers();
builder.Services.AddSwaggerConfiguration();



var app = builder.Build();
app.UseSerilogConfiguration();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwaggerConfiguration();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();