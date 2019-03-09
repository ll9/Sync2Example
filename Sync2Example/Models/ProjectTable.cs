using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sync2Example.Models
{
    public class ProjectTable
    {
        public ProjectTable()
        {

        }

        public ProjectTable(string name, string projectId)
        {
            Name = name;
            ProjectId = projectId;
        }

        public ProjectTable(string name, Project project)
        {
            Name = name;
            Project = project;
            ProjectId = Project.Id;
        }

        public string Name { get; set; }
        public Project Project { get; set; }
        public string ProjectId { get; set; }
    }
}
