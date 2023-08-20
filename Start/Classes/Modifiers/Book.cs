namespace Modifiers
{
    // access modifiers control how properties and methods are accessed
    class Book
    {
        // TODO: "public" members and methods can be accessed by any other code
        // Note: this is *NOT* the right way to expose internal data
        public string _name;

        public string get_name()
        {
            return this._name;
        }

        public void set_name(string _name)
        {
            this._name = _name;
        }


        // TODO: "protected" members can only be accessed by the class or a
        // derived class from this one
        protected string _author;

        public string get_author()
        {
            return this._author;
        }

        public void set_author(string _author)
        {
            this._author = _author;
        }


        // TODO: "private" is the default and can only be accessed by code
        // within the class itself
        private int _pagecount;

        public int get_pagecount()
        {
            return this._pagecount;
        }

        public void set_pagecount(int _pagecount)
        {
            this._pagecount = _pagecount;
        }


        public Book(string name, string author, int pages)
        {
            _name = name;
            _author = author;
            _pagecount = pages;
        }

        public string GetDescription()
        {
            return $"{_name} by {_author}, {_pagecount} pages";
        }

        // TODO: Member variables can be accessed via methods

    }
}
