using ResumeData.Models;
using System.Collections.Generic;

namespace ResumeData
{
    public interface IProject
    {
        Project Get(int projectId);
        IEnumerable<Project> GetAll();

        void AddTagToProject(int projectId, int tagId);
        void AddVideoToProject(int projectId, Video newVideo);
        void AddPictureToProject(int projectId, Picture newPic);
        void Add(Project newProject);

        void Remove(int projectId);
        void RemoveVideoFromProject(int projectId);
        void RemovePictureFromProject(int projectId, Picture remPic);//?
        void RemoveTagFromProject(int projectId, string tagName);//?
    }
}
