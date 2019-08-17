using Microsoft.EntityFrameworkCore;
using ResumeData;
using ResumeData.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ResumeServices
{
    public class ProjectServices : IProject
    {
        private ResumeContext _context;

        public ProjectServices(ResumeContext context)
        {
            _context = context;
        }

        public Project Get(int projectId)
        {
            return GetAll().FirstOrDefault(x => x.Id == projectId);
        }

        public IEnumerable<Project> GetAll()
        {
            return _context.Projects
                .Include(p => p.Pictures)
                .Include(p => p.Tags);
        }

        public IEnumerable<Project> GetThreeOrLess()
        {
            var all = GetAll();
            if (all.Count() >= 3)
            {
                Random rnd = new Random(DateTime.UtcNow.Millisecond);
                IEnumerable<Project> three = null;

                List<int> allIndexList = new List<int>(all.Count());
                for (int i = 0; i < all.Count(); i++)
                    allIndexList.Add(i + 1);

                List<int> retIndexList = new List<int>(3);
                for (int i = 0; i < 3; i++)
                {
                    int rValue = rnd.Next(0, allIndexList.Count - 1);
                    retIndexList.Add(allIndexList[rValue]);
                    allIndexList.RemoveAt(rValue);
                }


                for (int i = 0; i < retIndexList.Count; i++)//dont work
                    three = all.Where(x => retIndexList.Contains(x.Id));

                return three;
            }
            else
                return all;
        }

        public IEnumerable<Project> GetAllByTag(string tag)
        {
            var projectsId = _context.Tags.Where(x => x.TagName == tag);

            return GetAll()
                .Where(x => x.Tags.Any(y => projectsId.Contains(y)));
        }

        public void Add(Project newProject)
        {
            _context.Add(newProject);
            _context.SaveChanges();
        }

        public void AddPictureToProject(int projectId, Picture picture)
        {
            Project curProject = Get(projectId);
            curProject.Pictures.Concat(new[] { picture });

            _context.Update(curProject);
            _context.SaveChanges();
        }

        public void AddTagToProject(int projectId, int tagId)
        {
            Project curProject = Get(projectId);

            Tag tagForAdding = _context.Tags.FirstOrDefault(x => x.Id == tagId);

            curProject.Tags.Concat(new[] { tagForAdding });
            _context.Update(curProject);
            _context.SaveChanges();
        }

        public void AddVideoToProject(int projectId, Video newVideo)
        {
            Project curProject = Get(projectId);
            curProject.ProjectVideo = newVideo;
            _context.Update(curProject);
            _context.SaveChanges();
        }

        public void Remove(int projectId)
        {
            Project remProject = Get(projectId);
            _context.Remove(remProject);
            _context.SaveChanges();
        }

        public void RemovePictureFromProject(int projectId, Picture remPic)
        {
            Project curProject = Get(projectId);
            curProject.Pictures = curProject.Pictures.Where(x => x != remPic);
            _context.Update(curProject);
            _context.SaveChanges();
        }

        public void RemoveTagFromProject(int projectId, string tagName)
        {
            Project curProject = Get(projectId);
            curProject.Tags = curProject.Tags.Where(x => x.TagName != tagName);
            _context.Update(curProject);
            _context.SaveChanges();
        }

        public void RemoveVideoFromProject(int projectId)
        {
            Project curProject = Get(projectId);
            curProject.ProjectVideo = null;
            _context.Update(curProject);
            _context.SaveChanges();
        }


    }
}
