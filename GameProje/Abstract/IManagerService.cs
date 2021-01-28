using GameProje.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Abstract
{
    public interface IManagerService
    {
        public void Add(IEntity entity);
        public void Delete(string entity);
        public void Update(string entity);
        public void List();
    }
}
