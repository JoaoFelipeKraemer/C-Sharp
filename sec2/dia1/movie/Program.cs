class Program
{
    public static void Main(string[] args)
    {
        var movie = new Movie("Matrix", "Ficçao");
        var movie2 = new Movie("LOTR", "Fantasia");
        Console.WriteLine(movie.Title);
        Console.WriteLine(movie2.Title);
        movie.Title = "Matrix2";
    }
}