namespace Domain.Models;

public sealed record ProjectName
{
    private string Value { get; init; }

    private ProjectName(string value)
    {
        Value = value;
    }

    public static ProjectName Create(string name) => new(name);

    public static implicit operator string(ProjectName name) => name.Value;
    public static implicit operator ProjectName(string name) => Create(name);
}