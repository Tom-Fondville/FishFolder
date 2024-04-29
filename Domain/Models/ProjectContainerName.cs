namespace Domain.Models;

public sealed record ProjectContainerName
{
    private string Value { get; init; }

    private ProjectContainerName(string name)
    {
        Value = name;
    }

    private static ProjectContainerName Create(string name) => new(name);

    public static implicit operator string(ProjectContainerName projectContainerName) => projectContainerName.Value;
    public static implicit operator ProjectContainerName(string projectContainerName) => Create(projectContainerName);
}