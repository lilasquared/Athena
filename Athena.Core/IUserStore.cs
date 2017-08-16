using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Athena.Core
{
    public interface IUserStore
    {
        User Get(Int32 id);
        IEnumerable<User> GetAll();
        Boolean Contains(Expression<Func<User, Boolean>> predicate);
        void Save(User user);
    }
}