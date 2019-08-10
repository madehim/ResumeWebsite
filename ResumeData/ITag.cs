using ResumeData.Models;
using System.Collections.Generic;

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
