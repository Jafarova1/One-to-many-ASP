using FrontendBackend.Models;

namespace FrontendBackend.ViewModels
{
    public class HomeVM
    {
        public List<Service> services { get; set; }
        public List<Features> features { get; set; }
        public List<Projects> projects { get; set; }
        public List<Experts> experts { get; set; }
        public List<Testimonial> testimonials { get; set; }
        public List<Slider> sliders { get; set; }
        public List<Video> videos { get; set; }
      
    }
}
