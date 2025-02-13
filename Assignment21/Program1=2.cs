using System;

class Movie
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;
    public Movie Next;
    public Movie Prev;

    public Movie(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Next = null;
        Prev = null;
    }
}

class MovieList
{
    private Movie head;
    private Movie tail;

    public void AddMovieAtEnd(string title, string director, int year, double rating)
    {
        Movie newMovie = new Movie(title, director, year, rating);
        if (head == null)
        {
            head = tail = newMovie;
            return;
        }
        tail.Next = newMovie;
        newMovie.Prev = tail;
        tail = newMovie;
    }

    public void AddMovieAtBeginning(string title, string director, int year, double rating)
    {
        Movie newMovie = new Movie(title, director, year, rating);
        if (head == null)
        {
            head = tail = newMovie;
            return;
        }
        newMovie.Next = head;
        head.Prev = newMovie;
        head = newMovie;
    }

    public void AddMovieAtPosition(string title, string director, int year, double rating, int position)
    {
        if (position == 1)
        {
            AddMovieAtBeginning(title, director, year, rating);
            return;
        }
        Movie newMovie = new Movie(title, director, year, rating);
        Movie temp = head;
        for (int i = 1; temp != null && i < position - 1; i++)
        {
            temp = temp.Next;
        }
        if (temp == null)
        {
            Console.WriteLine("Invalid position.");
            return;
        }
        newMovie.Next = temp.Next;
        if (temp.Next != null)
        {
            temp.Next.Prev = newMovie;
        }
        temp.Next = newMovie;
        newMovie.Prev = temp;
    }

    public void RemoveMovie(string title)
    {
        Movie temp = head;
        while (temp != null && temp.Title != title)
        {
            temp = temp.Next;
        }
        if (temp == null)
        {
            Console.WriteLine("Movie not found.");
            return;
        }
        if (temp == head)
        {
            head = temp.Next;
        }
        if (temp == tail)
        {
            tail = temp.Prev;
        }
        if (temp.Prev != null)
        {
            temp.Prev.Next = temp.Next;
        }
        if (temp.Next != null)
        {
            temp.Next.Prev = temp.Prev;
        }
    }

    public Movie SearchMovieByDirector(string director)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.Director == director)
            {
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public Movie SearchMovieByRating(double rating)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.Rating == rating)
            {
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public void UpdateMovieRating(string title, double newRating)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.Title == title)
            {
                temp.Rating = newRating;
                Console.WriteLine("Rating updated successfully.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Movie not found.");
    }

    public void DisplayMoviesForward()
    {
        Movie temp = head;
        while (temp != null)
        {
            Console.WriteLine("Title: " + temp.Title + ", Director: " + temp.Director + ", Year: " + temp.Year + ", Rating: " + temp.Rating);
            temp = temp.Next;
        }
    }

    public void DisplayMoviesReverse()
    {
        Movie temp = tail;
        while (temp != null)
        {
            Console.WriteLine("Title: " + temp.Title + ", Director: " + temp.Director + ", Year: " + temp.Year + ", Rating: " + temp.Rating);
            temp = temp.Prev;
        }
    }
}

class Program2
{


    public static void Main()
    {
        MovieList movieList = new MovieList();

        movieList.AddMovieAtEnd("Inception", "Christopher Nolan", 2010, 8.8);
        movieList.AddMovieAtEnd("Titanic", "James Cameron", 1997, 7.8);
        movieList.AddMovieAtBeginning("The Matrix", "Lana Wachowski", 1999, 8.7);
        movieList.AddMovieAtPosition("Interstellar", "Christopher Nolan", 2014, 8.6, 2);

        Console.WriteLine("\nMovies (Forward Order):");
        movieList.DisplayMoviesForward();

        Console.WriteLine("\nMovies (Reverse Order):");
        movieList.DisplayMoviesReverse();

        Console.WriteLine("\nSearching for a Movie by Director (Christopher Nolan):");
        Movie foundMovie = movieList.SearchMovieByDirector("Christopher Nolan");
        if (foundMovie != null)
            Console.WriteLine("Found: " + foundMovie.Title);
        else
            Console.WriteLine("Movie not found.");

        Console.WriteLine("\nUpdating Rating for 'Inception':");
        movieList.UpdateMovieRating("Inception", 9.0);

        Console.WriteLine("\nDeleting Movie 'Titanic':");
        movieList.RemoveMovie("Titanic");

        Console.WriteLine("\nUpdated Movie Records:");
        movieList.DisplayMoviesForward();
    }
}
