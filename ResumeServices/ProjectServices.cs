using ResumeData;
using ResumeData.Models;
using System;
using System.Collections.Generic;

namespace ResumeServices
{
    public class ProjectServices : IProject
    {
        private ResumeContext _context;

        public ProjectServices(ResumeContext context)
        {
            _context = context;
        }

        public void Add(Project newProject)
        {
            throw new NotImplementedException();
        }

        public void AddPictureToProject(int projectId, string link)
        {
            throw new NotImplementedException();
        }

        public void AddTagToProject(int projectId, int tagId)
        {
            throw new NotImplementedException();
        }

        public void AddVideoToProject(int projectId, string link)
        {
            throw new NotImplementedException();
        }

        public Project Get(int projectId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int projectId)
        {
            throw new NotImplementedException();
        }

        public void RemovePictureFromProject(int projectId, int picNum)
        {
            throw new NotImplementedException();
        }

        public void RemoveTagFromProject(int projectId, string tagName)
        {
            throw new NotImplementedException();
        }

        public void RemoveVideoFromProject(int projectId)
        {
            throw new NotImplementedException();
        }
    }
}
