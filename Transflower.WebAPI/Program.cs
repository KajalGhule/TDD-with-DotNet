using Transflower.WebAPI.Services;
using Transflower.WebAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


builder.Services.AddScoped<ISubjectRepository, SubjectRepository>();
builder.Services.AddScoped<ISubjectService, SubjectService>();
var app = builder.Build();

// Usual middleware and pipeline config
if (app.Environment.IsDevelopment())
{

}
app.UseHttpsRedirection();
app.MapControllers();
app.Run();

