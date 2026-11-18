using api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IMathServices, MathServices>();
builder.Services.AddScoped<ISayHelloServices, SayHelloServices>();
builder.Services.AddScoped<IComparisonServices, ComparisonServices>();
builder.Services.AddScoped<IMagic8BallServices, Magic8BallServices>();
builder.Services.AddScoped<IRestaurantPickerServices, RestaurantPickerServices>();
builder.Services.AddScoped<IMadLibServices, MadLibServices>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Frontend", policy =>
    {
        policy.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("Frontend");

app.MapControllers();

app.Run();
