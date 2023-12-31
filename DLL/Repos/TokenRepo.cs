﻿using DLL.EF.Models;
using DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repos
{
    internal class TokenRepo : DataRepository, IRepo<Token, int, bool, string>
    {
        public bool Create(Token obj)
        {
            _context.Tokens.Add(obj);
            int chk = _context.SaveChanges();
            return chk > 0;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Token> GetAll(bool isAdmin = true)
        {
            return _context.Tokens.ToList();
        }

        public Token GetByID(int id)
        {
            return _context.Tokens.Find(id);
        }

        public List<Token> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Update(Token obj)
        {
            try
            {
                var tokenInDb = _context.Tokens.FirstOrDefault(t => t.Id == obj.Id);
                if (tokenInDb != null)
                {
                    tokenInDb.ExpiredAt = obj.ExpiredAt;
                    return _context.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
