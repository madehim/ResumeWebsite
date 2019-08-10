using ResumeData.Models;
using System.Collections.Generic;

namespace ResumeData
{
    public interface IProject
    {
        Project Get(int projectId);
        IEnumerable<Project> GetAll();

        void AddTagToProject(int projectId, int tagId);
        void AddVideoToProject(int projectId, string link);
        void AddPictureToProject(int projectId, string link);
        void Add(Project newProject);

        void Remove(int projectId);
        void RemoveVideoFromProject(int projectId);
        void RemovePictureFromProject(int projectId, int picNum);//?
        void RemoveTagFromProject(int projectId, string tagName);//?
    }
}
