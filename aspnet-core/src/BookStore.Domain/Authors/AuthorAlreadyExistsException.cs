using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;

namespace BookStore.Authors
{
    public class AuthorAlreadyExistsException : BusinessException
    {
        public AuthorAlreadyExistsException(string name)
            : base("Book:1")
        {
            WithData("name", name);
        }
    }
}
