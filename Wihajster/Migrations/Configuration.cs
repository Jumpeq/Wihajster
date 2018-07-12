using System.Collections.Generic;
using Wihajster.Models;

namespace Wihajster.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Wihajster.DAL.WihajsterDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Wihajster.DAL.WihajsterDbContext context)
        {
            var categories = new List<Category>
            {
                new Category {CategoryName = "Meble",Name = "mebel", Description = "test1", MainPicture = "https://7.allegroimg.com/s512/034115/092e4a194b97b2b38aad69f063a7"},
                new Category {CategoryName = "Oœwietlenie",Name = "oœwietleñ", Description = "test2",MainPicture = "https://fiverr-res.cloudinary.com/images/t_main1,q_auto,f_auto/gigs/75122551/original/01a3a9f8b91ccfb3f847ff5f4e829123fa3d868d/make-a-custom-rare-pepe-the-frog.jpg"},
                new Category {CategoryName = "Meble", Name = "mebelMebel",Description = "test3",MainPicture = "https://static.altchar.com/live/media/images/950x633_ct/8316_pepe_ced5e127ce114c48f3e9f57652142f2d.jpg"},
                new Category {CategoryName = "Bibeloty",Name = "mebel-Bibelot", Description = "test4",MainPicture = "https://cdn.cnn.com/cnnnext/dam/assets/160927210830-tk-ah0927-exlarge-169.jpg"},
                new Category {CategoryName = "Antyki", Name = "mebelAntyk",Description = "test5",MainPicture = "https://fiverr-res.cloudinary.com/images/t_main1,q_auto,f_auto/gigs/75122551/original/01a3a9f8b91ccfb3f847ff5f4e829123fa3d868d/make-a-custom-rare-pepe-the-frog.jpg"},
                new Category {CategoryName = "Antyki",Name = "antyczek", Description = "test6",MainPicture = "https://cdn.cnn.com/cnnnext/dam/assets/160927210830-tk-ah0927-exlarge-169.jpg"},
                new Category {CategoryName = "Bibeloty",Name = "bibelocik", Description = "test7",MainPicture = "https://7.allegroimg.com/s512/034115/092e4a194b97b2b38aad69f063a7"}
            };
            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();
            var pictures = new List<Picture>
            {
                new Picture{CategoryId = 1, ImageUrl = "https://7.allegroimg.com/s512/034115/092e4a194b97b2b38aad69f063a7"},
                new Picture{CategoryId = 1, ImageUrl = "https://7.allegroimg.com/s512/034115/092e4a194b97b2b38aad69f063a7"},
                new Picture{CategoryId = 1, ImageUrl = "https://7.allegroimg.com/s512/034115/092e4a194b97b2b38aad69f063a7"},
                new Picture{CategoryId = 1, ImageUrl = "https://7.allegroimg.com/s512/034115/092e4a194b97b2b38aad69f063a7"},
                new Picture{CategoryId = 2, ImageUrl = "https://fiverr-res.cloudinary.com/images/t_main1,q_auto,f_auto/gigs/75122551/original/01a3a9f8b91ccfb3f847ff5f4e829123fa3d868d/make-a-custom-rare-pepe-the-frog.jpg"},
                new Picture{CategoryId = 2, ImageUrl = "https://fiverr-res.cloudinary.com/images/t_main1,q_auto,f_auto/gigs/75122551/original/01a3a9f8b91ccfb3f847ff5f4e829123fa3d868d/make-a-custom-rare-pepe-the-frog.jpg"},
                new Picture{CategoryId = 3, ImageUrl = "https://static.altchar.com/live/media/images/950x633_ct/8316_pepe_ced5e127ce114c48f3e9f57652142f2d.jpg"},
                new Picture{CategoryId = 3, ImageUrl = "https://static.altchar.com/live/media/images/950x633_ct/8316_pepe_ced5e127ce114c48f3e9f57652142f2d.jpg"},
                new Picture{CategoryId = 3, ImageUrl = "https://static.altchar.com/live/media/images/950x633_ct/8316_pepe_ced5e127ce114c48f3e9f57652142f2d.jpg"},
                new Picture{CategoryId = 4, ImageUrl = "https://cdn.cnn.com/cnnnext/dam/assets/160927210830-tk-ah0927-exlarge-169.jpg"},
                new Picture{CategoryId = 4, ImageUrl = "https://cdn.cnn.com/cnnnext/dam/assets/160927210830-tk-ah0927-exlarge-169.jpg"},
                new Picture{CategoryId = 4, ImageUrl = "https://cdn.cnn.com/cnnnext/dam/assets/160927210830-tk-ah0927-exlarge-169.jpg"},
                new Picture{CategoryId = 4, ImageUrl = "https://cdn.cnn.com/cnnnext/dam/assets/160927210830-tk-ah0927-exlarge-169.jpg"},
                new Picture{CategoryId = 4, ImageUrl = "https://cdn.cnn.com/cnnnext/dam/assets/160927210830-tk-ah0927-exlarge-169.jpg"}
            };
            pictures.ForEach(s => context.Pictures.Add(s));
            context.SaveChanges();
        }
    }
}
