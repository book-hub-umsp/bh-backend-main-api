﻿namespace Storage.PostgreSQL.Abstractions;

public interface IUnitOfWork
{
    public void SaveChanges();
}
