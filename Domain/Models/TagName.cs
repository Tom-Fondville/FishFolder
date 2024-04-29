namespace Domain.Models;

public sealed record TagName
{
    private string Value { get; init; }

    private TagName(string value)
    {
        Value = value;
    }

    public static TagName Create(string name)
    {
        return new TagName(name);
    }

    public static implicit operator string(TagName name) => name.Value;
}