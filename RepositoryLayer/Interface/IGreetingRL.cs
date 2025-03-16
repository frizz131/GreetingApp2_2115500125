﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Model;
using RepositoryLayer.DTO;

namespace RepositoryLayer.Interface
{
    public interface IGreetingRL
    {
        string GetGreeting();
        bool AddGreeting(GreetingDTO greetingDTO);
        GreetingDTO GetGreetingById(int id);
        List<GreetingDTO> GetAllGreetings();
        bool UpdateGreeting(int id, string newValue);
        bool DeleteGreeting(int id);
    }
}