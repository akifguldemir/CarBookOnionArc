using CarbookDomain.Entities;

namespace CarBookApplication.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        public List<Blog> GetLast3BlogsWithAuthors();
    }
}
