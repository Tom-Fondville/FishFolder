using System;

namespace Domain.Models;

public sealed record ProjectId
{
    private string Value { get; init; }

    private ProjectId(string value)
    {
        Value = value;
    }

    public static ProjectId Create() => new ProjectId(Guid.NewGuid().ToString());

    public static ProjectId Create(string id) => new(id);

    public static implicit operator string(ProjectId id) => id.Value;
}