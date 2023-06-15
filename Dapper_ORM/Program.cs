







using Dapper_ORM;





AuthorRepository authorRepository = new AuthorRepository();
//var author = authorRepository.AddAuthor(new Author
//{
//    FirstName = "Ilyas",
//    LastName = "Efendiyev",
//});



//Console.WriteLine(author);



//var authors = authorRepository.GetAuthors().ToList();




//authors.ForEach(author => Console.WriteLine(author));






//authorRepository.AddAuthors(new[]
//{
//    new Author{FirstName = "Mirze Elekber",LastName="Tahirzade" },
//    new Author{FirstName = "Semed",LastName="Vekilov" },
//    new Author{FirstName = "Isa",LastName="Huseynov" },
//    new Author{FirstName = "Nikolay",LastName="Qoqol" },
//    new Author{FirstName = "Abbas",LastName="Mehdizade" },
//    new Author{FirstName = "Celil",LastName="Memedquluzade" },
//    new Author{FirstName = "Yusif Vezir",LastName="Chemenzemenli" },
//}
//);






//var authors = authorRepository.GetAuthors().ToList();




//authors.ForEach(author => Console.WriteLine(author));








authorRepository.RemoveAuthorsByIds(new int[] { 1 });