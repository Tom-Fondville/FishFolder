using System.Collections.Generic;
using System.IO;

namespace Domain.Models;

public sealed record ProjectContainer
{
    private readonly HashSet<Project> _projects;
    public IReadOnlySet<Project> Projects => _projects;

    // private readonly HashSet<ProjectContainer> _projectContainers;
    // public IReadOnlySet<ProjectContainer> ProjectContainers => _projectContainers;
    
    public FolderPath FolderPath { get; init; }
    public ProjectContainerName Name { get; init; }

    public ProjectContainer(FolderPath folderPath, ProjectContainerName name)
    {
        FolderPath = folderPath;
        Name = name;
        // _projectContainers = new();
        _projects = new();
    }
    
    public ProjectContainer(FolderPath folderPath, ProjectContainerName name, HashSet<Project> projects, HashSet<ProjectContainer> projectContainers)
    {
        FolderPath = folderPath;
        Name = name;
        _projects = projects;
        // _projectContainers = projectContainers;
    }

    public bool AddProjectFromExisting(FolderPath projectPath, ProjectName projectName)
    {
        if (!Directory.Exists(projectPath)) return false;
        
        
        return _projects.Add(new Project
        {
            Name = projectName,
            ProjectPath = projectPath,
            Tags = [],
            ProjectId = ProjectId.Create()
        });
    }

    public bool AddNewProject(FolderPath projectPath, ProjectName projectName)
    {
        if (!Directory.Exists(projectPath))
        {
            Directory.CreateDirectory(projectPath);
        }

        return _projects.Add(new Project
        {
            Name = projectName,
            ProjectPath = projectPath,
            Tags = [],
            ProjectId = ProjectId.Create()
        });
    }
    
    
}