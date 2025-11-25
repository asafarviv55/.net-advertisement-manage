using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class AdCreative
    {
        public int AdCreativeID { get; set; }
        public int AdID { get; set; }
        public string CreativeName { get; set; }
        public string CreativeType { get; set; } // Image, Video, Text, Carousel, Interactive
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }
        public string Headline { get; set; }
        public string BodyCopy { get; set; }
        public string CallToAction { get; set; }
        public string LandingPageUrl { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedOn { get; set; }

        public Advertisement Advertisement { get; set; }
    }
}
