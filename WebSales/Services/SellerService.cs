﻿using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using WebSales.Data;
using WebSales.Models;
using WebSales.Services.Exceptions;

namespace WebSales.Services;

public class SellerService
{
    private readonly WebSalesContext _context;
    public SellerService(WebSalesContext context)
    {
        _context = context;
    }
    public List<Seller> FindAll()
    {
        return _context.Seller.ToList();
    }

    public void Insert(Seller obj)
    {
        _context.Add(obj);
        _context.SaveChanges();
    }

    public Seller FindById(int id)
    {
        return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
    }

    public void Remove(int id)
    {
        var obj = _context.Seller.Find(id);
        _context.Seller.Remove(obj);
        _context.SaveChanges();
    }

    public void Update(Seller obj)
    {
        if(!_context.Seller.Any(x => x.Id == obj.Id))
        {
            throw new NotFoundException("Id not found");
        }
        try
        {
            _context.Update(obj);
            _context.SaveChanges();
        }
        catch (DbUpdateConcurrencyException e)
        {
            throw new DbUpdateConcurrencyException(e.Message);
        }
    }
}
