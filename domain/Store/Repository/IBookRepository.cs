using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Repository
{
    public interface IBookRepository
    {
        /// <summary>
        /// Получает все книги по заголовку
        /// </summary>
        /// <param name="titlePart">Вводимый Title</param>
        /// <returns></returns>
        List<Book> GetAllByTitle(string titlePart);
    }
}
