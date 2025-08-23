using EternaApp.Models;

namespace EternaApp.ViewModels
{
    public class HomeVm
    {
        public List<Slider> Sliders { get; set; } = new List<Slider>();
        public List<Client> Clients { get; set; } = new List<Client>();
    }
}