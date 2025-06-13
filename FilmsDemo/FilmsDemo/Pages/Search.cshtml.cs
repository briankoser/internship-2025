using DM.MovieApi;
using DM.MovieApi.MovieDb.Configuration;
using DM.MovieApi.MovieDb.Movies;
using FilmsDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FilmsDemo.Pages;

public class SearchModel(ILogger<IndexModel> logger) : PageModel
{
    private readonly ILogger<IndexModel> _logger = logger;

    [BindProperty(SupportsGet = true)]
    public string? SearchString { get; set; }

    public IList<Film> Films { get; set; } = new List<Film>();

    public async Task OnGetAsync()
    {
        if (!string.IsNullOrEmpty(SearchString))
        {
            var configApi = MovieDbFactory.Create<IApiConfigurationRequest>().Value;
            var configResponse = await configApi.GetAsync();

            var movieApi = MovieDbFactory.Create<IApiMovieRequest>().Value;
            var searchResponse = await movieApi.SearchByTitleAsync(SearchString);

            Films = searchResponse.Results.Select(result =>
                {
                    return new Film()
                    {
                        Id = result.Id,
                        Title = result.Title,
                        Genres = result.Genres.Select(genre => genre.Name),
                        Overview = result.Overview,
                        Popularity = result.Popularity,
                        PosterPath = $"{configResponse.Item.Images.RootUrl}w220_and_h330_face{result.PosterPath}",
                        ReleaseDate = result.ReleaseDate
                    };
                }).ToList();
        }
    }
}