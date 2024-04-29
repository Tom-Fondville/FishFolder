namespace Domain.Models;

public sealed record Tag
{
    public required TagName TagName { get; init; }
    public required bool IsCustomTag { get; init; }
}