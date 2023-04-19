using Entities.Models;
using Entities.RequestFeature;

namespace Repositories.Contracts
{
    public interface IBookRepository : IRepositoryBase<Book>
    {
        Task<PagedList<Book>> GetAllBooksAsync(BookParameters bookParameters, bool trackChanges);
        Task<List<Book>> GetAllBooksAsync(bool trackChanges);
        Task<Book> GetOneBookByIdAsync(int id, bool trackChanges);
        void CreateOneBook(Book book);
        void DeleteOneBook(Book book);
        void UpdateOneBook(Book book);

        Task<IEnumerable<Book>> GetAllBooksWithDetailsAsync(bool trackChanges);
    }
}
