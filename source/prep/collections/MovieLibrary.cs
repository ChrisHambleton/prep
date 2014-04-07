using System;
using System.Collections.Generic;
using System.Linq;

namespace prep.collections
{
  public class MovieLibrary
  {
    IList<Movie> movies;

    public MovieLibrary(IList<Movie> list_of_movies)
    {
      this.movies = list_of_movies;
    }

    public IEnumerable<Movie> all_movies()
    {
      return this.movies.OfType<Movie>();      
    }

    public void add(Movie movie)
    {
      if (this.movies.Contains(movie) == false && titleExists(movie.title) == false)
      {        
          this.movies.Add(movie);
      }
    }

    public bool titleExists(string title)
    {
      bool exists = false;
      foreach (Movie movie in this.movies)
      {
        if (title.ToLower() == movie.title.ToLower())
        {
          exists = true;
          break;
        }
      }
      return exists;
    }

    public IEnumerable<Movie> all_movies_published_by_pixar()
    {
      List<Movie> filtered = new List<Movie>();
      foreach (Movie movie in this.movies)
      {
        if (movie.production_studio == ProductionStudio.Pixar)
          filtered.Add(movie);
      }
      
      return filtered;
    }

    public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
    {
      List<Movie> filtered = new List<Movie>();
      foreach (Movie movie in this.movies)
      {
        if (movie.production_studio == ProductionStudio.Pixar || movie.production_studio == ProductionStudio.Disney)
          filtered.Add(movie);
      }

      return filtered;
    }

    public IEnumerable<Movie> all_movies_not_published_by_pixar()
    {
      List<Movie> filtered = new List<Movie>();
      foreach (Movie movie in this.movies)
      {
        if (movie.production_studio != ProductionStudio.Pixar)
          filtered.Add(movie);
      }

      return filtered;
    }

    public IEnumerable<Movie> all_movies_published_after(int year)
    {
      List<Movie> filtered = new List<Movie>();
      foreach (Movie movie in this.movies)
      {
        if (movie.date_published.Year > year)
          filtered.Add(movie);
      }

      return filtered;
    }

    public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
    {
      List<Movie> filtered = new List<Movie>();
      foreach (Movie movie in this.movies)
      {
        if (movie.date_published.Year >= startingYear && movie.date_published.Year <= endingYear)
          filtered.Add(movie);
      }

      return filtered;
    }

    public IEnumerable<Movie> all_kid_movies()
    {
      List<Movie> filtered = new List<Movie>();
      foreach (Movie movie in this.movies)
      {
        if (movie.genre == Genre.kids)
          filtered.Add(movie);
      }

      return filtered;
    }

    public IEnumerable<Movie> all_action_movies()
    {
      List<Movie> filtered = new List<Movie>();
      foreach (Movie movie in this.movies)
      {
        if (movie.genre == Genre.action)
          filtered.Add(movie);
      }

      return filtered;
    }

    public IEnumerable<Movie> sort_all_movies_by_title_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_title_ascending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
    {
      throw new NotImplementedException();
    }
  }
}
