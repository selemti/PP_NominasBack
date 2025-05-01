using PP_NominasBack.Profiles;
using PP_NominasBack.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Mongo + AutoMapper
builder.Services.Configure<MongoSettings>(
    builder.Configuration.GetSection("MongoConnection"));
builder.Services.AddSingleton<MongoContext>();
builder.Services.AddAutoMapper(typeof(CatalogosProfile));

// MVC y Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
