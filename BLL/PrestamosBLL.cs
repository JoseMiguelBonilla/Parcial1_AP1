using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Prueba2.DAL;
using Prueba2.Models;

namespace Prueba2.BLL 
{
    public class PrestamosBLL
    {
        private readonly Contexto _contexto;

        public PrestamosBLL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Guardar(Prestamos Prestamos)
        {
           
            if (!Existe(Prestamos.PrestamoId))
                return Insertar(Prestamos);
            else
                return Modificar(Prestamos);
        }

        public bool Existe(int PrestamoId)
        {
            return _contexto.Prestamos.Any(s => s.PrestamoId == PrestamoId);
        }

        private bool Insertar(Prestamos Prestamos)
        {
            _contexto.Prestamos.Add(Prestamos);
            int cantidad = _contexto.SaveChanges();
            return cantidad > 0;
        }

        public bool Modificar(Prestamos Prestamos)
        {
            _contexto.Update(Prestamos);
            int cantidad = _contexto.SaveChanges();
            return cantidad > 0;
        }

        public bool Eliminar(Prestamos Prestamos)
        {
            _contexto.Prestamos.Remove(Prestamos);
            int cantidad = _contexto.SaveChanges();
            return cantidad > 0;
        }

        public Prestamos? Buscar(int PrestamoId)
        {
            return _contexto.Prestamos
                .AsNoTracking()
                .FirstOrDefault(s => s.PrestamoId == PrestamoId);
        }

          public List<Prestamos> GetList(Expression<Func<Prestamos, bool>> Criterio)
        {
            return _contexto.Prestamos
                .Where(Criterio)
                .AsNoTracking()
                .ToList();
        }
    }
}