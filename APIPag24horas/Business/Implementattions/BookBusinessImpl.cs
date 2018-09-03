using System.Collections.Generic;
using APIPag24horas.Data.Converters;
using APIPag24horas.Data.VO;
using APIPag24horas.Model;
using APIPag24horas.Repository.Generic;

namespace APIPag24horas.Business.Implementattions
{
	public class BookBusinessImpl : IBookBusiness
    {
        private IRepository<Book> _repository;
        private readonly BookConverter _converter;

        public BookBusinessImpl(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }

        public BookVO Create(BookVO book)
        {
            var BookEntity = _converter.Parse(book);
            BookEntity = _repository.Create(BookEntity);
            return _converter.Parse(BookEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<BookVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public BookVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public BookVO Update(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Update(bookEntity);
            return _converter.Parse(bookEntity);
        }
    }
}
