using Common.Database.Transaction;
using Common.Database.Transaction.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Inje��o da classe de transa��o de banco de dados da entidade Produto
builder.Services.AddSingleton<IProdutoTransaction, ProdutoTransaction>();

var app = builder.Build();

// Configura��o de permiss�o de rota de origem da requisi��o
app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().SetIsOriginAllowed(origin => true));

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
