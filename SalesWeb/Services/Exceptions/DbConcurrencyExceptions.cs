﻿namespace SalesWeb.Services.Exceptions
{
    public class DbConcurrencyExceptions : ApplicationException
    {
        public DbConcurrencyExceptions(string message) : base(message) { }
    }
}
