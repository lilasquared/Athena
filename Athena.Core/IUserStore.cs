using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Athena.Core
{
    public interface IUserStore
    {
        void Save(User user);
        IEnumerable<User> GetAll();
        Boolean Contains(Expression<Func<User, Boolean>> predicate);
    }
}