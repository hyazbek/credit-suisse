﻿using System;
using System.Linq;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;

namespace movie_service.HttpClients;

public static class TmdbService
{
    public static List<SearchMovie> SearchMovies(string query)
    {
        List<SearchMovie> result = new();
        TMDbClient client = new TMDbClient("b4deb664afe3d5005f9f04f34dbb32fa");
        SearchContainer<SearchMovie> searchContainer = client.SearchMovieAsync(query).Result;

        foreach(SearchMovie movie in searchContainer.Results.Take(1))
        {
            result.Add(movie);
        }

        return result;
    }

    public static List<SearchTv> SearchTvSeason(string query)
    {
        List<SearchTv> result = new();
        TMDbClient client = new TMDbClient("b4deb664afe3d5005f9f04f34dbb32fa");
        SearchContainer<SearchTv> searchContainer = client.SearchTvShowAsync(query).Result;

        foreach (SearchTv series in searchContainer.Results)
        {
            result.Add(series);
        }

        return result;
    }

    public static List<SearchPerson> SearchCelebrity(string query)
    {
        List<SearchPerson> result = new();
        TMDbClient client = new TMDbClient("b4deb664afe3d5005f9f04f34dbb32fa");
        SearchContainer<SearchPerson> searchContainer = client.SearchPersonAsync(query).Result;

        foreach (SearchPerson celebrity in searchContainer.Results)
        {
            result.Add(celebrity);
        }

        return result;
    }
}