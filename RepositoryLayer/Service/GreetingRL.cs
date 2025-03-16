﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Context;
using RepositoryLayer.DTO;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;

namespace RepositoryLayer.Service
{
    public class GreetingRL : IGreetingRL
    {
        private readonly GreetingDBContext _context;

        public GreetingRL(GreetingDBContext context)
        {
            _context = context;
        }
        public bool AddGreeting(GreetingDTO greetingDTO)
        {
            if (_context.Greetings.Any(g => g.Key == greetingDTO.Key))
                return false;

            var greeting = new GreetingEntity
            {
                Key = greetingDTO.Key,
                Value = greetingDTO.Value
            };

            _context.Greetings.Add(greeting);
            return _context.SaveChanges() > 0;

        }
        public string GetGreeting()
        {
            return "Hello World";
        }
    }
}