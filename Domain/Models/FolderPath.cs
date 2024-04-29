namespace Domain.Models;

public sealed record FolderPath
{
    private string Value { get; init; }

    private FolderPath(string value)
    {
        Value = value;
    }

    public static FolderPath Create(string path)
    {
        return new FolderPath(path);
    }

    public static implicit operator string(FolderPath path) => path.Value;
    public static implicit operator FolderPath(string path) => Create(path);
}