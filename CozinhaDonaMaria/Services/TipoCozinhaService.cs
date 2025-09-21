using System.Collections.Generic;
using System.Linq;
using CozinhaDonaMaria.Models;

namespace CozinhaDonaMaria.Services
{
    public static class TipoCozinhaService
    {
        private static List<TipoCozinha> tipos = new List<TipoCozinha>();
        private static int ultimoId = 0;

        public static void Adicionar(TipoCozinha tipo)
        {
            ultimoId++;
            tipo.Id = ultimoId;
            tipos.Add(tipo);
        }

        public static List<TipoCozinha> Listar()
        {
            return tipos;
        }

        public static TipoCozinha BuscarPorId(int id)
        {
            return tipos.FirstOrDefault(t => t.Id == id);
        }

        public static void Remover(int id)
        {
            var tipo = BuscarPorId(id);
            if (tipo != null)
            {
                tipos.Remove(tipo);
            }
        }

        public static void Atualizar(TipoCozinha tipoAtualizado)
        {
            var tipo = BuscarPorId(tipoAtualizado.Id);
            if (tipo != null)
            {
                tipo.Nome = tipoAtualizado.Nome;
            }
        }
    }
}

