using DocProject.Models;
using DocProject.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DocProject.Controllers
{
    
    public class RestoController : Controller
    {
        // GET: RestoController
        private readonly Irepo restaurantRepository;
        public List<Resto> Restos { get; set; }
        public RestoController(Irepo irepo)
        {
            this.restaurantRepository = irepo;
        }
        [ResponseHeader("name","value")]
        public ActionResult Index()
        {
            //ViewBag.Restaurant = "";
            //TempData["som"] = "tempDat";
            //  dynamic test = new { test = "tee" };
            Restos = restaurantRepository.GetAllResto();
            if (Restos!=null)
            {
                return View(Restos);
            }
            return View();
           
          
        }
        [Route("RouteExample")]
        public ActionResult RouteExample() => View("RouteExample");
        // GET: RestoController/Details/5
        public ActionResult Details(int id)
        {
            var resto = restaurantRepository.GetResto(id);
            if (resto!=null)
                 return View(resto);
            return View();
        }

        // GET: RestoController/Create
        public ActionResult Create()
        {
            var g = TempData["som"];
            return View();
        }

        // POST: RestoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Resto r)
        {
             
            int uuid = restaurantRepository.getTheLastId();
            r.uuid = ++uuid;
            try
            {
               
                restaurantRepository.AddResto(r);
                return RedirectToAction(nameof(Index));


            }
            catch
            {
                return View();
            }
        }

        // GET: RestoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(restaurantRepository.GetResto(id));
        }

        // POST: RestoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Resto res)
        {
            try
            {
                restaurantRepository.UpdateResto(res,id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RestoController/Delete/5
        public ActionResult Delete(int id)
        {
           
            return View();
        }

        // POST: RestoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Resto collection)
        {
            try
            {
                restaurantRepository.DeleteResto(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
