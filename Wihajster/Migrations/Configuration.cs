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
                new Category {CategoryName = "Meble",Name = "Krzes³o", Description = "test test test", MainPicture = "https://meblownia.pl/media/products/9338e77fa8a2bb1bc3abf7933bc38ee2/images/thumbnail/large_1512393733krzeslo-manuel-szare-perspektywa.JPG?lm=1527503393", Prize = 60},
                new Category {CategoryName = "Oœwietlenie",Name = "¯arówka", Description = "Œwietne ¿arówki",MainPicture = "https://elampki.pl/pol_pl_Zarowka-Led-Ozdobna-E27-9794-Nowodvorski-Lighting-4813_1.jpg", Prize=45},
                new Category {CategoryName = "Meble", Name = "Szafka",Description = "Du¿o ró¿nych szafek",MainPicture = "https://d.allegroimg.com/s512/0393d0/2935d42043b8ab41732b95a9bb7d", Prize = 120},
                new Category {CategoryName = "Bibeloty",Name = "Bibelot", Description = "Brak opisu",MainPicture = "https://bi.gazeta.pl/im/2/10427/z10427582Q,Wycinanka-50-x-50-cm.jpg",Prize = 20},
                new Category {CategoryName = "Antyki", Name = "Szafa",Description = "Œwietna szafa",MainPicture = "https://thumbs.img-sprzedajemy.pl/1000x901c/18/45/53/szafa-antyk-zachodniopomorskie-szczecinek-274165677.jpg",Prize = 500},
                new Category {CategoryName = "Antyki",Name = "Kuchnia", Description = "Stara kuchnia",MainPicture = "https://www.i60.cz/images/tricycle-838398-960-720.jpg",Prize = 3200},
                new Category {CategoryName = "Bibeloty",Name = "bibelocik", Description = "Fantastyczny bibelocik",MainPicture = "https://s14.flog.pl/media/foto/9936670_co-poniedzialek-pchli-targ-antyki--bibeloty-etc.jpg",Prize = 32}
            };
            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();
            var pictures = new List<Picture>
            {
                new Picture{CategoryId = 1, ImageUrl = "https://cdn2.dekoria.com/image/djpg/36846/36846.1/350/350/Krzeslo-Sogo-Light-Grey-.jpg"},
                new Picture{CategoryId = 1, ImageUrl = "https://lepukka.pl/4996-large_default/krzeslo-roxie.jpg"},
                new Picture{CategoryId = 2, ImageUrl = "https://lampalampa.pl/image/cache/data/zarowki-ozdobne-2015/zarowka-dekoracyjna-edison-st64-001-900x900.jpg"},
                new Picture{CategoryId = 2, ImageUrl = "https://lampalampa.pl/image/cache/data/zarowki-ozdobne-2015/zarowka-br95-led-3W-600x315.jpg"},
                new Picture{CategoryId = 2, ImageUrl = "https://www.2bm.pl/files/1964994651/zarnikowa-zarowka-dekoracyjna-spiral-125mm-60w,w_1200,_small.jpg"},
                new Picture{CategoryId = 3, ImageUrl = "https://cdn4.jysk.com/getimage/wd2.large/86120"},
                new Picture{CategoryId = 3, ImageUrl = "https://www.abra-meble.pl/media/catalog/product/a/b/abra-16-06-27-one-poj-11-sonoma.jpg"},
                new Picture{CategoryId = 3, ImageUrl = "https://c.allegroimg.com/s512/013cb0/2cba76e44926a23f1705d90af9ec"},
                new Picture{CategoryId = 4, ImageUrl = "https://s14.flog.pl/media/foto/9936670_co-poniedzialek-pchli-targ-antyki--bibeloty-etc.jpg"},
                new Picture{CategoryId = 4, ImageUrl = "https://img01-olxpl.akamaized.net/img-olxpl/680486055_4_644x461_wazony-wazoniki-dzbanek-z-prl-u-bibeloty-sport-i-hobby.jpg"},
                new Picture{CategoryId = 5, ImageUrl = "https://thumbs.img-sprzedajemy.pl/1000x901c/d4/d1/0e/duza-szafa-sieniowa-eklektyczna-renowacji-antyk-481707290.jpg"},
                new Picture{CategoryId = 5, ImageUrl = "https://thumbs.img-sprzedajemy.pl/1000x901c/34/a2/aa/szafa-gdanska-antyk-warszawa-414518542.jpg"},
                new Picture{CategoryId = 6, ImageUrl = "https://img01-olxpl.akamaized.net/img-olxpl/650162103_3_644x461_stary-kredens-kuchnia-antyk-do-renowacji-pozostale-meble.jpg"},
                new Picture{CategoryId = 6, ImageUrl = "https://img01-olxpl.akamaized.net/img-olxpl/636741193_2_644x461_regal-komoda-antyk-kuchnia-do-renowacji-dodaj-zdjecia_rev001.jpg"},
                new Picture{CategoryId = 7, ImageUrl = "https://img01-olxpl.akamaized.net/img-olxpl/680486055_4_644x461_wazony-wazoniki-dzbanek-z-prl-u-bibeloty-sport-i-hobby.jpg"}
            };
            pictures.ForEach(s => context.Pictures.Add(s));
            context.SaveChanges();
        }
    }
}
