using ResumeData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeData
{
    public interface ITag
    {
        Tag Get(int tagId);
        IEnumerable<Tag> GetAll();

        void Add(Tag newTag);
        void Remove(string tagName); //?
    }
}
