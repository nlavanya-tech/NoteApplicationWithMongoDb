using System;
using System.ComponentModel.DataAnnotations;

namespace NoteApplication.Entities
{
    public class Notes
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }
        public string Author { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}
