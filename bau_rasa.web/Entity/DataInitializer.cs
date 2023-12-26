using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using bau_rasa.web.Identity;

namespace bau_rasa.web.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {

        protected override void Seed(DataContext context)
        {

            var Kategoriler = new List<Category>()
            {
                new Category() { Name ="Parfüm", Description="Parfümler"},
                new Category() { Name ="Ev Ürünleri", Description="Ev ve koku ürünleri"},
                new Category() { Name ="Cilt Bakım Ürünleri", Description="Cilt bakımı"},

            };

            foreach (var kategori in Kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                //PARFÜM
                new Product() { Name ="Kirke EDP 100 ml Unisex Parfüm", Description = "Tiziana Terenzi", Price = 8504, Stock = 100, IsApproved =true, CategoryId =1,Image="kirke1.png"},
                new Product() { Name ="Nero Oudh EDP 100 ml Unisex Parfüm", Description = "Tiziana Terenzi", Price = 14320, Stock = 100, IsApproved =true, CategoryId =1, Image="nero1.png" },
                new Product() { Name ="Gumin EDP 100 ml Unisex Parfüm", Description = "Tiziana Terenzi", Price = 17827, Stock = 100, IsApproved =true, CategoryId =1,Image="gumin1.png"},
                new Product() { Name ="Adhil EDP 100 ml Unisex Parfüm", Description = "Tiziana Terenzi", Price = 34534, Stock = 100, IsApproved =true, CategoryId =1,Image="adhil1.png"},
                new Product() { Name ="Atlantide EDP 100 ml Unisex Parfüm", Description = "Tiziana Terenzi", Price = 38980, Stock = 100, IsApproved =true, CategoryId =1,Image="atlantide1.png"},

                new Product() { Name ="Hero EDP 100 ml Erkek Parfüm", Description = "Burberry", Price = 3240, Stock = 400, IsApproved =true, CategoryId =1,Image="burberry1.png",},
                new Product() { Name ="Goddess EDP 50 ml Kadın Parfüm", Description = "Burberry", Price = 2360, Stock = 400, IsApproved =true, CategoryId =1,Image="goddess1.png",},
                new Product() { Name ="Mr. Burberry EDT 100 ml Erkek Parfüm", Description = "Burberry", Price = 1365, Stock = 400, IsApproved =true, CategoryId =1,Image="mr-burberry1.png",},
                new Product() { Name ="Her EDP 50 ml Kadın Parfüm", Description = "Burberry", Price = 2157, Stock = 400, IsApproved =true, CategoryId =1,Image="her-edp1webp.png",},
                new Product() { Name ="Her London Dream EDP 100 ml Kadın Parfüm", Description = "Burberry", Price = 2404, Stock = 400, IsApproved =true, CategoryId =1,Image="her-london1.png",},

                //new Product() { Name ="Bottled Night Eau De Toilette 100 ml Erkek Parfümü", Description = "Hugo Boss", Price = 1561, Stock = 200, IsApproved =true, CategoryId =1,Image="night1.png" },
                //new Product() { Name ="The Scent Eau De Toilette Erkek Parfümü 100 ml", Description = "Hugo Boss", Price = 2244, Stock = 200, IsApproved =true, CategoryId =1,Image="scentmen1.png" },
                //new Product() { Name ="Bottled Pacific Edt Erkek Parfüm 100 ml ", Description = "Hugo Boss", Price = 1994, Stock = 200, IsApproved =true, CategoryId =1,Image="pasific1.png" },
                //new Product() { Name ="Alive Eau De Parfum Intense Kadın Parfümü 50 ml", Description = "Hugo Boss", Price = 2123, Stock = 200, IsApproved =true, CategoryId =1,Image="alive1.png" },
                //new Product() { Name ="The Scent Magnetic For Her Eau De Parfum Kadın Parfümü 50 ml", Description = "Hugo Boss", Price = 1930, Stock = 200, IsApproved =true, CategoryId =1,Image="magnetic1.png" },

                new Product() { Name ="Tony Iommi Monkey Special 50 ml Parfüm", Description = "Xerjoff", Price = 9840, Stock = 150, IsApproved =true, CategoryId =1,Image="tony-iommi1.png" },
                new Product() { Name ="Casamorati 1888 EDP 100 ml Erkek Parfüm", Description = "Xerjoff", Price = 11340, Stock = 150, IsApproved =true, CategoryId =1,Image="1888-1.png" },
                new Product() { Name ="Casamorati Lira EDP 100 ml Kadın Parfüm", Description = "Xerjoff", Price = 11790, Stock = 150, IsApproved =true, CategoryId =1,Image="lira1.png" },
                new Product() { Name ="Erba Pura EDP 100 ml Parfüm", Description = "Xerjoff", Price = 10265, Stock = 150, IsApproved =true, CategoryId =1,Image="erba-pura1.png" },
                new Product() { Name ="Layla 50 ml Parfüm", Description = "Xerjoff", Price = 9210, Stock = 150, IsApproved =true, CategoryId =1,Image="layla1webp.png" },
                new Product() { Name ="Apollonia 50 ml Kadın Parfüm", Description = "Xerjoff", Price = 9840, Stock = 150, IsApproved =true, CategoryId =1,Image="apollonia1.png" },


                //EV ÜRÜNLERİ
                new Product() { Name ="French Cade & Lavender Taraklı Kenarlı Cam Kapta 175 gr Mum", Description = "Voluspa", Price = 780, Stock = 800, IsApproved =true, CategoryId =2,Image="scalloped-edge-candle-french-cade-lavender1.png"},
                new Product() { Name ="Santiago Huckleberry Taraklı Kenarlı Cam Kapta 175 gr Mum", Description = "Voluspa", Price = 780, Stock = 800, IsApproved =true, CategoryId =2,Image="scalloped-edge-candle-santiago-huckleberry1_min.png"},
                new Product() { Name ="Goji & Tarocco Orange 100 ml Oda ve Vücut Spreyi", Description = "Voluspa", Price = 742, Stock = 800, IsApproved =true, CategoryId =2,Image="room-and-body-mist-goji-tarocco-orange1.png"},

                new Product() { Name ="White Tea Seramik Kapta Mum", Description = "Giardino Benessere", Price = 398, Stock = 1200, IsApproved =true, CategoryId =2,Image="ben-earthenware-white-tea-1898_min.png"},
                new Product() { Name ="Sandalo & Mirra Ahşap Fitilli Mum", Description = "Giardino Benessere", Price = 1199, Stock = 1200, IsApproved =true, CategoryId =2,Image="candle-sandal-myrrh-1894_min.png"},

                new Product() { Name ="Blanc de Sisa EDP 250 gr Kokulu Mum", Description = "Simimi", Price = 854, Stock = 1000, IsApproved =true, CategoryId =2,Image="r-ve-de-sisa-candle-1.png"},
                new Product() { Name ="Esprit de Candela EDP 250 gr Kokulu Mum", Description = "Simimi", Price = 778, Stock = 1000, IsApproved =true, CategoryId =2,Image="esprit-de-candela-candle-1.png"},
                new Product() { Name ="Mémoire d'Anna EDP 250 gr Kokulu Mum", Description = "Simimi", Price = 946, Stock = 1000, IsApproved =true, CategoryId =2,Image="m-moire-d-anna-candle-250-gr-1221_min.png"},
                new Product() { Name ="Grâce de Klavdia EDP 250 gr Kokulu Mum", Description = "Simimi", Price = 1236, Stock = 1000, IsApproved =true, CategoryId =2,Image="gr-ce-de-klavdia-candle-1.png"},


                //CİLT BAKIM ÜRÜNLERİ
                new Product() { Name ="Solution Micellaire Anti age 400 ml (Göz ve Yüz İçin Temizleme Suyu)", Description = "FILORGA", Price = 679, Stock = 800, IsApproved =true, CategoryId =3,Image="solution-micellaire-anti-age-400-ml-yaslilik-karsiti-tonik-2834_min.png"},
                new Product() { Name ="Nutri-Filler Lips 4 gr (Besleyici Dudak Kremi)", Description = "FILORGA", Price = 855, Stock = 800, IsApproved =true, CategoryId =3,Image="nutri-filler-lips-4-gr-besleyici-dudak-kremi-3756_min.png"},
                new Product() { Name ="Global Repair Essence 150 ml (Global Yaşlanma Karşıtı Esens)", Description = "FILORGA", Price = 1951, Stock = 800, IsApproved =true, CategoryId =3,Image="global-repair-essence-150-ml-global-yaslanma-karsiti-bakim-losyonu-2844_min.png"},
                new Product() { Name ="Meso-Mask 50 ml (Cildi Düzenleyen Aydınlatıcı Maske)", Description = "FILORGA", Price = 1345, Stock = 800, IsApproved =true, CategoryId =3,Image="meso-mask-50-ml-kirisik-engelleyici-ve-cilt-aydinlatici-maske-2859_min.png"},

                new Product() { Name ="Bariederm Cica Daily Serum 30ml", Description = "URIAGE", Price = 895, Stock = 700, IsApproved =true, CategoryId =3,Image="bariederm-cica-daily-serum-30ml-2441_min.png"},
                new Product() { Name ="Tolederm Control Soin Yeux TP 15ml", Description = "URIAGE", Price = 375, Stock = 700, IsApproved =true, CategoryId =3,Image="tolederm-control-soin-yeux-tp-15ml-2540_min.png"},
                new Product() { Name ="Bariésun Brume Séche Hydratant SPF50+ 200 ml", Description = "URIAGE", Price = 471, Stock = 700, IsApproved =true, CategoryId =3,Image="bariesun-spf50-brume-seche-a-200ml-2379_min.png"},
                new Product() { Name ="Gel Surgras Dermatologique F 500ml", Description = "URIAGE", Price = 391, Stock = 700, IsApproved =true, CategoryId =3,Image="gel-surgras-dermatologique-f-500ml-2324_min.png"},
                new Product() { Name ="D.S. Hair Anti Dandruff Balancing Shampoo", Description = "URIAGE", Price = 423, Stock = 700, IsApproved =true, CategoryId =3,Image="d-s-hair-anti-dandruff-balancing-shampoo-2370_min.png"},

            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "admin", Description = "admin rolü" };
                manager.Create(role);

            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "user", Description = "user rolü" }; ;
                manager.Create(role);

            }

            if (!context.Users.Any(i => i.Name == "beyorsa"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "Omer", Surname = "Kacmaz", UserName = "Beyorsa", Email = "beyorsahk@mail.com" };
                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");

            }

            if (!context.Users.Any(i => i.Name == "messi"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "Leo", Surname = "Messi", UserName = "Messi", Email = "messi123@mail.com" };
                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "user");

            }

            base.Seed(context);
        }
    }
    
}