using System.Collections.Generic;
using System.Linq;
using CozinhaDonaMaria.Models;

namespace CozinhaDonaMaria.Services
{
    public static class IngredienteService
    {
        private static List<Ingrediente> ingredientes = new List<Ingrediente>();
        private static int ultimoId = 0;

        public static void Adicionar(Ingrediente ingrediente)
        {
            ultimoId++;
            ingrediente.Id = ultimoId;
            ingredientes.Add(ingrediente);
        }

        public static List<Ingrediente> Listar()
        {
            return ingredientes;
        }

        public static Ingrediente BuscarPorId(int id)
        {
            return ingredientes.FirstOrDefault(i => i.Id == id);
        }

        public static void Remover(int id)
        {
            var ingrediente = BuscarPorId(id);
            if (ingrediente != null)
            {
                ingredientes.Remove(ingrediente);
            }
        }

        public static void Atualizar(Ingrediente ingredienteAtualizado)
        {
            var ingrediente = BuscarPorId(ingredienteAtualizado.Id);
            if (ingrediente != null)
            {
                ingrediente.Nome = ingredienteAtualizado.Nome;
                ingrediente.UnidadeMedida = ingredienteAtualizado.UnidadeMedida;
            }
        }
    }
}