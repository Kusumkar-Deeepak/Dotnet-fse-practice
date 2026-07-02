namespace FirstWebAPI.Models;

public sealed record ValueItem(int Id, string Name);

public sealed record ValueUpsertRequest(string? Name);