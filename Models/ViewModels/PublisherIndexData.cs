using Sonkodi_Cozma_Cristian_Lab2.Models;

namespace Sonkodi_Cozma_Cristian_Lab2.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}