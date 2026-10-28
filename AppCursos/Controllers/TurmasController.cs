
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppCursos.Models;
using AppCursos.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

public class TurmasController : Controller
{
    private readonly ApplicationDbContext _context;

    public TurmasController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: TURMAS
    public async Task<IActionResult> Index()
    {
        var listaTurmas = await _context.Turmas.Include(t => t.Curso).Include(t => t.Professor).ToListAsync();
        return View(listaTurmas);
    }

    // GET: TURMAS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var turma = await _context.Turmas
            .FirstOrDefaultAsync(m => m.Id == id);
        if (turma == null)
        {
            return NotFound();
        }

        return View(turma);
    }

    // GET: TURMAS/Create
    public IActionResult Create()
    {
        // Enviar SelectList de Cursos
        ViewBag.CursoId = new SelectList(_context.Cursos, "Id", "Nome");
        // Enviar SelectList de Professores
        ViewBag.ProfessorId = new SelectList(_context.Professores, "Id", "Nome");

        return View();
    }

    // POST: TURMAS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Nome,CursoId,Curso,ProfessorId,Professor")] Turma turma)
    {
        if (ModelState.IsValid)
        {
            _context.Add(turma);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // Enviar SelectList de Cursos com a opção selecionada 
        ViewBag.CursoId = new SelectList(_context.Cursos, "Id", "Nome", turma.CursoId);

        // Enviar SelectList de Professores com a opção selecionada
        ViewBag.ProfessorId = new SelectList(_context.Professores, "Id", "Nome", turma.ProfessorId);

        return View(turma);
    }

    // GET: TURMAS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var turma = await _context.Turmas.FindAsync(id);
        if (turma == null)
        {
            return NotFound();
        }
        return View(turma);
    }

    // POST: TURMAS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Nome,CursoId,Curso,ProfessorId,Professor")] Turma turma)
    {
        if (id != turma.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(turma);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TurmaExists(turma.Id))
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
        return View(turma);
    }

    // GET: TURMAS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var turma = await _context.Turmas
            .FirstOrDefaultAsync(m => m.Id == id);
        if (turma == null)
        {
            return NotFound();
        }

        return View(turma);
    }

    // POST: TURMAS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var turma = await _context.Turmas.FindAsync(id);
        if (turma != null)
        {
            _context.Turmas.Remove(turma);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool TurmaExists(int? id)
    {
        return _context.Turmas.Any(e => e.Id == id);
    }
}
