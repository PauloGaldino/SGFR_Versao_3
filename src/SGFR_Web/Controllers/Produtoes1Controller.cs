using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities.Producao;
using InfraData.Data.Context;

namespace SGFR_Web.Controllers
{
    public class Produtoes1Controller : Controller
    {
        private readonly DbContextoGeral _context;

        public Produtoes1Controller(DbContextoGeral context)
        {
            _context = context;
        }

        // GET: Produtoes1
        public async Task<IActionResult> Index()
        {
            var dbContextoGeral = _context.Produtos.Include(p => p.Categoria).Include(p => p.Cliente).Include(p => p.Imposto);
            return View(await dbContextoGeral.ToListAsync());
        }

        // GET: Produtoes1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .Include(p => p.Categoria)
                .Include(p => p.Cliente)
                .Include(p => p.Imposto)
                .FirstOrDefaultAsync(m => m.ProdutoId == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // GET: Produtoes1/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "Descricao");
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "Email");
            ViewData["ImpostoId"] = new SelectList(_context.Imposto, "ImpostoId", "Descricao");
            return View();
        }

        // POST: Produtoes1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProdutoId,CategoriaId,ImpostoId,ClienteId,Descricao,PrecoUnitario,Lote,DataFabricacao,DataValidade,DataCadastro,Ativo,Disponivel")] Produto produto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "Descricao", produto.CategoriaId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "Email", produto.ClienteId);
            ViewData["ImpostoId"] = new SelectList(_context.Imposto, "ImpostoId", "Descricao", produto.ImpostoId);
            return View(produto);
        }

        // GET: Produtoes1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "Descricao", produto.CategoriaId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "Email", produto.ClienteId);
            ViewData["ImpostoId"] = new SelectList(_context.Imposto, "ImpostoId", "Descricao", produto.ImpostoId);
            return View(produto);
        }

        // POST: Produtoes1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProdutoId,CategoriaId,ImpostoId,ClienteId,Descricao,PrecoUnitario,Lote,DataFabricacao,DataValidade,DataCadastro,Ativo,Disponivel")] Produto produto)
        {
            if (id != produto.ProdutoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoExists(produto.ProdutoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "Descricao", produto.CategoriaId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "Email", produto.ClienteId);
            ViewData["ImpostoId"] = new SelectList(_context.Imposto, "ImpostoId", "Descricao", produto.ImpostoId);
            return View(produto);
        }

        // GET: Produtoes1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .Include(p => p.Categoria)
                .Include(p => p.Cliente)
                .Include(p => p.Imposto)
                .FirstOrDefaultAsync(m => m.ProdutoId == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produtoes1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoExists(int id)
        {
            return _context.Produtos.Any(e => e.ProdutoId == id);
        }
    }
}
