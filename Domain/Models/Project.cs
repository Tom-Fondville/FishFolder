using System.Collections.Generic;

namespace Domain.Models;

public sealed class Project
{
    public required ProjectId ProjectId { get; init; }
    public required ProjectName Name { get; init; }
    public required FolderPath ProjectPath { get; init; }
    public required HashSet<Tag> Tags { get; init; }


    private bool Equals(Project other) => ProjectId == other.ProjectId;

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is Project other && Equals(other);
    }

    public override int GetHashCode() => ProjectId.GetHashCode();
}