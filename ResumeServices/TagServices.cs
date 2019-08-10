using ResumeData;
using ResumeData.Models;
using System.Collections.Generic;
using System.Linq;

namespace ResumeServices
{
    class TagServices : ITag
    {
        private ResumeContext _contex;

        public TagServices(ResumeContext context)
        {
            _contex = context;
        }

        public void Add(Tag newTag)
        {
            _contex.Add(newTag);
            _contex.SaveChanges();
        }

        public Tag Get(int tagId)
        {
            return GetAll().FirstOrDefault(x => x.Id == tagId);
        }

        public IEnumerable<Tag> GetAll()
        {
            return _contex.Tags;
        }


        public void Remove(string tagName)
        {
            Tag remTag = GetByName(tagName);
            if (remTag != null)
            {
                _contex.Remove(remTag);
                _contex.SaveChanges();
            }

        }

        public Tag GetByName(string tagName)
        {
            return _contex.Tags.FirstOrDefault(x => x.TagName == tagName);
        }
    }
}
