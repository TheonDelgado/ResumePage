using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumePage.Models
{
    public class IndexViewModel
    {
        public string AboutDescription { get; set; }
        public string ResumeSummary { get; set; }

        public IndexViewModel()
        {
            AboutDescription = @"Enthusiatic and dedicated multifaceted software developer with a strong will to learn. 
            Able to take great challenges and break them down into smaller tasks in order to aid development with superior problem-solving skills
            Knowledgable in multiple frameworks such as ASP.NET MVC, Razor Pages, Unity Engine, and currently learning more.";

            ResumeSummary = @"Passionate and dedicated Web Developer with 1+ years experience designing and developing 
            business focused applications with a smooth user experience.";
        }
    }
}