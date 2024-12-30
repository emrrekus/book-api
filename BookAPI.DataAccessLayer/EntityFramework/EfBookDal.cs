using BookAPI.DataAccessLayer.Abstract;
using BookAPI.DataAccessLayer.Context;
using BookAPI.DataAccessLayer.Repository;
using BookAPI.EntityLayer.Concrete;
using BookAPI.DataAccessLayer.Dtos;

namespace BookAPI.DataAccessLayer.EntityFramework
{
    public class EfBookDal : GenericRepository<Book>, IBookDal
    {
        private readonly BookContext _context;
        public EfBookDal(BookContext context) : base(context)
        {
            _context = context;
        }

        public List<ResultBookDto> GetLast4Book()
        {
            return _context.Books.OrderByDescending(x => x.BookID)
                .Select(x => new ResultBookDto
                {
                    Title = x.Title,
                    Author = x.Writer.Name,
                    Price = x.Price,
                    ImageUrl = x.ImageUrl
                }).Take(4).ToList();
        }

        public ResultBookDto RandomBook()
        {
           Random random = new Random();
           int randomNumber = random.Next(1, _context.Books.Count());
           return _context.Books.OrderBy(x => x.BookID).Skip(randomNumber - 1).Select(x => new ResultBookDto
                {
                    Title = x.Title,
                    Author = x.Writer.Name,
                    Price = x.Price,
                    ImageUrl = x.Big_ImageUrl,
                    Description = x.Description
                }).FirstOrDefault();
        }
    }
} 