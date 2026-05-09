var builder = WebApplication.CreateBuilder(args);

// Tambahkan layanan Controller
builder.Services.AddControllers();

// 1. Tambahkan Swagger Generator
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 2. Konfigurasi HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    // Aktifkan Middleware Swagger
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
app.Run();