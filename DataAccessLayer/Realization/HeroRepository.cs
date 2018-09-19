﻿using DataAccessLayer.Interfaces;
using DataAccessLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccessLayer.Realization
{
    public class HeroRepository : IRepository<Heroes>
    {
        private TheWitcherEntities _dataBase;
        public HeroRepository()
        {
            _dataBase = new TheWitcherEntities();
        }
        public int Create(Heroes item)
        {
            if (item != null)
            {
                _dataBase.Heroes.Add(item);
                _dataBase.SaveChanges();
                return item.Id;
            }
            return -1;
        }

        public int Delete(int id)
        {
            Heroes hero = _dataBase.Heroes.Find(id);
            if (hero == null)
            {
                return -1;
            }
            _dataBase.Heroes.Remove(hero);
            _dataBase.SaveChanges();
            return id;

        }

        public Heroes GetItem(int id)
        {
            return _dataBase.Heroes.Find(id);
        }

        public IEnumerable<Heroes> GetItemList()
        {
            return _dataBase.Heroes.ToList();
        }

        public int Update(Heroes item)
        {
            if(item != null)
            {
                _dataBase.Entry(item).State = EntityState.Modified;
                _dataBase.SaveChanges();
                return item.Id;
            }
            return -1;
        }
    }
}
