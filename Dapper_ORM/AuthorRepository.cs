using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_ORM;

public class AuthorRepository : IAuthorRepository
{
    private IDbConnection _db;
    public AuthorRepository()
    {
        _db = new SqlConnection();
        _db.ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Library;Integrated Security=True;TrustServerCertificate=False;";
    }
    public Author AddAuthor(Author author)
    {
        var sql =
            @"INSERT INTO Authors(FirstName,LastName)
              VALUES (@FirstName,@LastName)
              SELECT CAST(SCOPE_IDENTITY() AS int)";
        var id = _db.Query<int>(sql, new 
        {
            @FirstName = author.FirstName,
            @LastName = author.LastName,
        }).FirstOrDefault();
        author.Id = id;
        return author;
    }

    public void AddAuthors(object[] authors)
    {
        var sql = @"INSERT INTO Authors(FirstName,LastName)
              VALUES (@FirstName,@LastName)";
        _db.Execute(sql, authors);
    }

    public Author GetAuthorById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Author> GetAuthors()
    {
        var sql = "SELECT * FROM Authors";
        return _db.Query<Author>(sql);
    }

    public void RemoveAuthor(int id)
    {
        _db.Execute("DELETE FROM Authors Where Id=@Id", new { @Id = id });
    }


    public void RemoveAuthorByIds(int[] authorIds)
    {
        for (int i = 0; i < authorIds.Length; i++)
        {
            RemoveAuthor(authorIds[i]);
        }
    }

    public void RemoveAuthorsByRange(int start, int end)
    {
        throw new NotImplementedException();
    }

    public Author UpdateAuthor(Author author)
    {
        throw new NotImplementedException();
    }

    public void UpdateAuthors(object[] authors)
    {
        throw new NotImplementedException();
    }
}
