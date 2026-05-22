var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => "API no ar");

app.MapPost("/orcamento", (Orcamento request) =>
{
    if (request.ClienteId == null)
        return Results.BadRequest("O campo 'ClienteId' é obrigatório");

    if (request.VeiculoId == null)
        return Results.BadRequest("O campo 'VeiculoId' é obrigatório");

    if (request.Itens == null || request.Itens.Count == 0)
        return Results.BadRequest("O campo 'Itens' é obrigatório e deve conter pelo menos um item");

    decimal totalOrcamento = 0;
    foreach (OrcamentoItem item in request.Itens)
    {
        if (string.IsNullOrWhiteSpace(item.Descricao))
            return Results.BadRequest("O campo 'Descrição' é obrigatório");

        if (item.Quantidade <= 0)
            return Results.BadRequest("O campo 'Quantidade' deve ser maior que zero");

        if (item.ValorUnitario <= 0)
            return Results.BadRequest("O campo 'ValorUnitário' deve ser maior que zero");

        totalOrcamento += item.Quantidade * item.ValorUnitario;
    }

    return Results.Ok(new
    {
        ClienteId = request.ClienteId,
        VeiculoId = request.VeiculoId,
        Itens = request.Itens,
        Total = totalOrcamento
    });
});

app.Run();