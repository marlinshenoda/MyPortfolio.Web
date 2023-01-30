

using MyPortoflio.Core.Entities;

namespace MyPortoflio.Web.Views.ViewModel
{
    public class HomeViewModel
    {
        public Owner Owner { get; set; }
        public List<PortfolioItem> PortfolioItems { get; set; }
    }
}
