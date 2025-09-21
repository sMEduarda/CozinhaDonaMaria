using System.Collections.Generic;
using System.Linq;
using CozinhaDonaMaria.Models;

namespace CozinhaDonaMaria.Services
{
    public static class ReceitaService
    {
        private static List<Receita> receitas = new List<Receita>();
        private static int ultimoId = 0;

        public static void Adicionar(Receita receita)
        {
            ultimoId++;
            receita.Id = ultimoId;
            receitas.Add(receita);
        }

        public static List<Receita> Listar()
        {
            return receitas;
        }

        public static Receita BuscarPorId(int id)
        {
            return receitas.FirstOrDefault(r => r.Id == id);
        }

        public static void Remover(int id)
        {
            var receita = BuscarPorId(id);
            if (receita != null)
            {
                receitas.Remove(receita);
            }
        }

        public static void Atualizar(Receita receitaAtualizada)
        {
            var receita = BuscarPorId(receitaAtualizada.Id);
            if (receita != null)
            {
                receita.Nome = receitaAtualizada.Nome;
                receita.Tipo = receitaAtualizada.Tipo;
                receita.Ingredientes = receitaAtualizada.Ingredientes;
                receita.ModoPreparo = receitaAtualizada.ModoPreparo;
            }
        }
    }
}