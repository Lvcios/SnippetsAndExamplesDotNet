﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWeb.Repository
{
    public interface IRepository<T> where T:Entity
    {
        List<T> List();
        void Save(T entity);
        void Update(T entity);
        void Delete(int Id);
        T GetById(int Id);
    }
}
