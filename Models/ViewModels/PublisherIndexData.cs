using Muresan_Alexandru_Vasile_Lab2.Models;
namespace Muresan_Alexandru_Vasile_Lab2.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
