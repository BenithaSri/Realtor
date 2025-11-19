using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Tumsas.RealEstate.Public.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        // Filter Inputs
        [BindProperty(SupportsGet = true)]
        public string Category { get; set; }

        [BindProperty(SupportsGet = true)]
        public decimal? PriceMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public decimal? PriceMax { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? AreaMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? AreaMax { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<string> RoomNumbers { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public List<int> FloorNumbers { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public List<int> BuildingAges { get; set; } = new();

        // Result List
        public List<PropertyResult> Results { get; set; } = new();

        public void OnGet()
        {
            // TODO: Replace with real data source
            Results = new List<PropertyResult>
            {
                new PropertyResult {
                    ImageUrl = "https://i0.shbdn.com/photos/11/16/63/lthmb_1115111663f4f.jpg",
                    Type = "Yazlık",
                    Title = "DAİRE FİYATINA 3+1 BAHÇELİ VİLLA",
                    Area = 200,
                    Rooms = "3+1",
                    Floor = 3
                },
                new PropertyResult {
                    ImageUrl = "https://i0.shbdn.com/photos/49/38/08/lthmb_1118493808m6r.jpg",
                    Type = "Yazlık",
                    Title = "3+0 BAHÇELİ VİLLA",
                    Area = 250,
                    Rooms = "3+0",
                    Floor = 2
                }
                // Add more mock data or query from DB
            };
        }

        public class PropertyResult
        {
            public string ImageUrl { get; set; }
            public string Type { get; set; }
            public string Title { get; set; }
            public int Area { get; set; }
            public string Rooms { get; set; }
            public int Floor { get; set; }
        }
    }
}