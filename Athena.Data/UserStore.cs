using Athena.Core;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Athena.Data
{
    public class UserStore : IUserStore
    {
        public LiteCollection<User> _users;

        public UserStore(LiteDatabase database)
        {
            _users = database.GetCollection<User>("users");
        }

        public IEnumerable<User> GetAll()
        {
            return _users.FindAll();
        }

        public void Save(User user)
        {
            _users.Insert(user);
        }

        public Boolean Contains(Expression<Func<User, Boolean>> predicate)
        {
            if (_users.FindOne(predicate) == null) return false;

            return true;
        }
    }
}