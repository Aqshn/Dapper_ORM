using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_ORM;

public interface IAuthorRepository
{
    Author AddAuthor(Author author);
    void AddAuthors(object[] authors);
    void RemoveAuthor(int id);
    void RemoveAuthorsByRange(int start,int end);
    void RemoveAuthorsByIds(int[] authorsIds);
    Author UpdateAuthor(Author author);
    void UpdateAuthors(object[] authors);
    Author GetAuthorById(int id);
    IEnumerable<Author> GetAuthors();

}
