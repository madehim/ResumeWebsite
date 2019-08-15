using Microsoft.EntityFrameworkCore;
using ResumeData.Models;
using System.Collections.Generic;

namespace ResumeData
{
    public class ResumeContext : DbContext
    {
        public ResumeContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new
                {
                    Id = 1,
                    ProjectName = "Брутфорс документов ВК",
                    ProjectDescription = "Ищет документы определенного пользователя. Возможен выбор пользователя по ид, рамки поиска документа (1-999999999), использование прокси.\n Для использования прокси, необходимо добавить файл proxylist.txt построчно содержащий прокси сервера в формате ip:port. Для каждого прокси сервера создается отдельный поток.\n Для получения списка команд используйте help. \n Информация о находках отображается на консоле и записывается в файл.",
                    ProjectGitHubLink = "https://github.com/madehim/vkDocBrute",

                    Pictures = new List<Picture> {
                        new Picture { Id= 1, Link="https://media.discordapp.net/attachments/425963895040114691/611575460190486529/vk_doc_brut.jpg"}
                    },
                    Tags = new List<Tag>
                    {
                        new Tag { Id= 1, TagName="C#"},
                        new Tag { Id = 2, TagName=".NET"},
                        new Tag  {Id = 3, TagName="ConsoleApp"}
                    }


                }



                );
        }
    }
}
