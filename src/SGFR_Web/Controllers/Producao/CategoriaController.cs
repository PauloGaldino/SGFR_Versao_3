using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces.Producao;
using AutoMapper;
using Domain.Entities.Producao;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SGFR_Web.ViewModels;

namespace SGFR_Web.Controllers.Producao
{
    [Authorize]
    public class CategoriaController : Controller
    {
        private readonly InterfaceCategoriaAppService _categoriaApp;

        public CategoriaController(InterfaceCategoriaAppService categoriaApp)
        {
            _categoriaApp = categoriaApp;
        }

        // GET: Produtos
        public ActionResult Index()
        {
            var CategoriaViewModel = Mapper.Map<IEnumerable<Categoria>, IEnumerable<CategoriaViewModel>>(_categoriaApp.GetAll());
            return View(CategoriaViewModel);
        }


        // GET: Produtos/Details/5
        public ActionResult Details(int id)
        {
            var Categoria = _categoriaApp.GetById(id);
            var CategoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(Categoria);

            return View(CategoriaViewModel);
        }

        // GET: Produtos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produtos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriaViewModel Categoria)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var CategoriaDomain = Mapper.Map<CategoriaViewModel, Categoria>(Categoria);
                    _categoriaApp.Add(CategoriaDomain);

                    return RedirectToAction("Index");
                }

                return View(Categoria);
            }
            catch
            {
                return View();
            }
        }

        // GET: Produtos/Edit/5
        public ActionResult Edit(int id)
        {

            var categoria = _categoriaApp.GetById(id);
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(categoria);

            return View(categoriaViewModel);
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoriaViewModel Categoria)
        {
            if (ModelState.IsValid)
            {
                var CategoriaDomain = Mapper.Map<CategoriaViewModel, Categoria>(Categoria);
                _categoriaApp.Update(CategoriaDomain);

                return RedirectToAction("Index");
            }

            return View(Categoria);
        }

        // GET: Produtos/Delete/5
        public ActionResult Delete(int id)
        {
            var Categoria = _categoriaApp.GetById(id);
            var CategoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(Categoria);

            return View(CategoriaViewModel);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var Categoria = _categoriaApp.GetById(id);
            _categoriaApp.Remove(Categoria);

            return RedirectToAction("Index");
        }
    }
}