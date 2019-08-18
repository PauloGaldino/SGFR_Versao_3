using Application.Interfaces.Vendas;
using AutoMapper;
using Domain.Entities.Vendas;
using Microsoft.AspNetCore.Mvc;
using SGFR_Web_v02.ViewModels.Vendas;
using System.Collections.Generic;

namespace SGFR_Web_v02.Controllers.Vendas
{
    public class ImpostoController : Controller
    {
        private readonly InterfaceImpostoAppService _impostoApp;

        public ImpostoController(InterfaceImpostoAppService impostoApp)
        {
            _impostoApp = impostoApp;
        }

        // GET: Produtos
        public ActionResult Index()
        {
            var ImpostoViewModel = Mapper.Map<IEnumerable<Imposto>, IEnumerable<ImpostoVIewModel>>(_impostoApp.GetAll());
            return View(ImpostoViewModel);
        }


        // GET: Produtos/Details/5
        public ActionResult Details(int id)
        {
            var Imposto = _impostoApp.GetById(id);
            var ImpostoViewModel = Mapper.Map<Imposto, ImpostoVIewModel>(Imposto);

            return View(ImpostoViewModel);
        }

        // GET: Produtos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produtos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ImpostoVIewModel Imposto)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var ImpostoDomain = Mapper.Map<ImpostoVIewModel, Imposto>(Imposto);
                    _impostoApp.Add(ImpostoDomain);

                    return RedirectToAction("Index");
                }

                return View(Imposto);
            }
            catch
            {
                return View();
            }
        }

        // GET: Produtos/Edit/5
        public ActionResult Edit(int id)
        {

            var imposto = _impostoApp.GetById(id);
            var impostoViewModel = Mapper.Map<Imposto, ImpostoVIewModel>(imposto);

            return View(impostoViewModel);
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ImpostoVIewModel Imposto)
        {
            if (ModelState.IsValid)
            {
                var ImpostoDomain = Mapper.Map<ImpostoVIewModel, Imposto>(Imposto);
                _impostoApp.Update(ImpostoDomain);

                return RedirectToAction("Index");
            }

            return View(Imposto);
        }

        // GET: Produtos/Delete/5
        public ActionResult Delete(int id)
        {
            var Imposto = _impostoApp.GetById(id);
            var ImpostoViewModel = Mapper.Map<Imposto, ImpostoVIewModel>(Imposto);

            return View(ImpostoViewModel);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var Imposto = _impostoApp.GetById(id);
            _impostoApp.Remove(Imposto);

            return RedirectToAction("Index");
        }
    }
}