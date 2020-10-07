using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.Azure.Documents;

namespace SampleApp
{
    //NOT USED
    public interface IRepository<T>
    {
        Database ReadDatabase(string db);
        DocumentCollection CreateorReadCollection(string dbLink, string collection);
        Document AddItem(string dbLink, T newItem);

        void DeleteDatabase(string db);
        void DeleteCollection(string collection);
        void DeleteItem(T item);

        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
    }
}
