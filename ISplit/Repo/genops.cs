﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Data.iFace;


namespace ISplit.Repo
{
    public class genops <T> : igenops<T> where T : class
    {
         protected readonly ApplicationDbContext _context;

    protected genops(ApplicationDbContext context)
    {
        _context = context;
    }

    

        public async Task<T> Get(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task Add(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }

        public Task<T> get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
