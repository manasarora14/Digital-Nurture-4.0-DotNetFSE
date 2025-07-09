using CustomEmployeeApi.Filters;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddControllers(options =>
{
    // ✅ Register the custom exception filter globally
    options.Filters.Add<CustomExceptionFilter>();
});

// ✅ Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ✅ Enable Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Middleware
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
