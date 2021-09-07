using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Classes
{
    class SerieRepository : IRepository<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Delete(int id)
        {
            listaSerie[id].Delete();
        }

        public void Insert(Serie entity)
        {
            listaSerie.Add(entity);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int NextId()
        {
            return listaSerie.Count();
        }

        public Serie ReturnById(int id)
        {
            return listaSerie[id];
        }

        public void Update(int id, Serie entity)
        {
            listaSerie[id] = entity;
        }
    }
}
