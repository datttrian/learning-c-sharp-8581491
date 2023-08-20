using Modifiers;

// create a new Book instance
Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);

b1._name = "Aldous Huxley";
Console.WriteLine(b1.GetDescription());

// set data using functions instead of accessing fields directly
b1.set_name("Grapes of Wrath");
b1.set_author("John Steinbeck");
b1.set_pagecount(464);

Console.WriteLine(b1.GetDescription());
