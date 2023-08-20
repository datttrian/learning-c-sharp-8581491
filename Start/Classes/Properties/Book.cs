namespace Properties;

public class Book
{
    // classes have instance variables to hold data
    private string _name;
    private string _author;
    private int _pagecount;

    // classes have one or more constructors
    public Book(string name, string author, int pages)
    {
        Name = name;
        Author = author;
        Pagecount = pages;
    }


    // TODO: use Properties to implement access to our internal data
    // This is called a Property with a "backing field"


    // TODO: There's a shorthand way of writing these using the => operator
    // to create "expression-bodied" properties
    public string Name { get => _name; set => _name = value; }
    public string Author { get => _author; set => _author = value; }
    public int Pagecount { get => _pagecount; set => _pagecount = value; }

    // TODO: You can omit the get or set if you want to prevent
    // modification or reading the value, or if you want to create
    // a "computed property" from other fields
    public string Description
    {
        get => $"{Name} by {Author}, {Pagecount} pages";
    }

    public string ISBN { get; set; }
    public decimal Price { get; set; }
}
