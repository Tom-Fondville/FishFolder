using System.Windows.Controls;
using Domain.Models;

namespace FishFolder.View.UserControls;

public partial class ProjectCard
{
    public ProjectCard()
    {
        DataContext = this;
        InitializeComponent();
    }

    private string _projectId;
    public string ProjectId
    {
        get => _projectId;
        set => SetField(ref _projectId, value);
    }
    
    private Project _project;
    public Project Project
    {
        get => _project;
        set => SetField(ref _project, value);
    }
    
    private string _projectName;
    public string ProjectName
    {
        get => _projectName;
        set => SetField(ref _projectName, value);
    }
}