using ResumeData;
using ResumeData.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
            throw new NotImplementedException();
        }

        public Tag Get(int tagId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(string tagName)
        {
            throw new NotImplementedException();
        }
    }
}
