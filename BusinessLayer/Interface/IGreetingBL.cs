﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Model;
using RepositoryLayer.DTO;

namespace BusinessLayer.Interface
{
    public interface IGreetingBL
    {
        string GetGreetingMessage(string firstName, string lastName);
        string GetPersonalizedGreeting(GreetingRequestModel request);
        bool AddGreeting(GreetingDTO greetingDTO);
        GreetingDTO GetGreetingById(int id);
        List<GreetingDTO> GetAllGreetings();
    }
}