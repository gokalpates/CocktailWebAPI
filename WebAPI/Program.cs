using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IGenericService<Cocktail>, CocktailManager>();
builder.Services.AddScoped<ICocktailDAL, EFCocktailRepository>();

builder.Services.AddScoped<IGenericService<Color>, ColorManager>();
builder.Services.AddScoped<IColorDAL,EFColorRepository>();

builder.Services.AddScoped<IGenericService<Glass>, GlassManager>();
builder.Services.AddScoped<IGlassDAL, EFGlassRepository>();

builder.Services.AddScoped<IGenericService<Ingredient>, IngredientManager>();
builder.Services.AddScoped<IIngredientDAL, EFIngredientRepository>();

builder.Services.AddScoped<IGenericService<Preparation>, PreparationManager>();
builder.Services.AddScoped<IPreparationDAL, EFPreparationRepository>();

builder.Services.AddScoped<IGenericService<Temperature>, TemperatureManager>();
builder.Services.AddScoped<ITemperatureDAL, EFTemperatureRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
