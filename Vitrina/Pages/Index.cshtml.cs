using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vitrina.Data;
using Vitrina.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Vitrina.Pages
{/*
  

    @functions{
        public string GetHello()
        {
            return "Hello";
        }
    }

    <button Onclick="RazorFunction()">Click</button>

    @section Scripts
    {
        <script>
    function RazorFunction() {
        $("button").html('@GetHello()');
    }

        </script>
    }

    <div style="border: 1px solid rgba(24, 24, 24, 0.4); box-sizing: border-box; border-radius: 16px; display: flex;flex-direction: row;justify-content: center;align-items: center;padding: 16px 20px;">
        <p style="color: #181818; font-size: 18px; line-height: 22px; margin: 0px 10px;">Сбросить</p>
    </div>
    
  <div style="margin:0% 20%; display: flex; justify-content: space-between; background:white; padding: 9px 16px; box-shadow: 0px 4px 20px rgba(0, 0, 0, 0.12);
border-radius: 16px; margin-bottom:25px;">
    <input type="text" asp-for="SearchString" />
    <a href=""><img src="https://i.ibb.co/HTspYk9/loupe-1.png" style="width:80%; vertical-align: middle; padding-right: 0px;" alt="loupe" border="0"></a>
</div>
  
  
  */
    public class IndexModel : PageModel
    {
        private readonly Vitrina.Data.VitrinaContext _context;
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }


        [BindProperty(SupportsGet = true)]
        public string TransportClassSearch { get; set; }
        public SelectList TransportClasses { get; set; }


        [BindProperty(SupportsGet = true)]
        public string TechDirectionsSearch { get; set; }
        public SelectList TexhDirections { get; set; }
        [BindProperty(SupportsGet = true)]
        public string OrganisationSearch { get; set; }
        public SelectList Organisations { get; set; }
        public List<string> OrganisationsDictionary { get; set; } = new List<string> { "Московский метрополитен", "Мосгортранс", "ЦОДД", "Организатор перевозок", "Мостранспроект", "АМПП" };
        public IndexModel(Vitrina.Data.VitrinaContext context)
        {
            _context = context;
        }


        public IList<SingleStartup> SingleStartup { get;set; }

        public async Task OnGetAsync()
        {
            var startups = from s in _context.SingleStartup select s;
            if (!string.IsNullOrEmpty(SearchString))
            {
                startups = startups.Where(r => r.Description.Contains(SearchString)||r.ShortDesc.Contains(SearchString)||r.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(TechDirectionsSearch))
            {
                startups = startups.Where(r => r.TechDir.Contains(TechDirectionsSearch));
            }
            if (!string.IsNullOrEmpty(TransportClassSearch))
            {
                startups = startups.Where(r => r.TransportClass.Contains(TransportClassSearch));
            }

            if (!string.IsNullOrEmpty(OrganisationSearch))
            {
                int filterCode = OrganisationsDictionary.IndexOf(OrganisationSearch);
                startups = startups.Where(r => r.Organisation == filterCode);
            }
            TransportClasses = new SelectList(new List<string> { "Метрополитен (электропоезда)", "Автобусы", "Электробусы ", "Трамваи", "Троллейбус", "Каршеринг", "Экспресс-маршруты","Монорельсовая дорога","МЦК","Такси","Аэроэкспресс","Маршрутное такси","Речные суда","Личные автомобили","Альтернативный вид транспорта","Другое" });
            TexhDirections = new SelectList(new List<string> { "Доступный и комфортный городской транспорт", "Новые виды мобильности", "Безопасность дорожного движения", "Здоровые улицы и экология", "Цифровые технологии в транспорте" });
            Organisations = new SelectList(OrganisationsDictionary); 
            SingleStartup = await startups.ToListAsync();
        }


    }
}
