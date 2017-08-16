using System;
using System.Collections.Generic;

namespace Athena.Web.Models
{
    public class BaseModel
    {
        public IList<String> Messages { get; }

        public BaseModel()
        {
            Messages = new List<String>();
        }

        public void AddMessage(String message)
        {
            if (String.IsNullOrWhiteSpace(message)) return;

            Messages.Add(message);
        }
    }
}