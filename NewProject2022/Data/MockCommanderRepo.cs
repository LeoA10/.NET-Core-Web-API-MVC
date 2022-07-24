﻿using NewProject2022.Models;
using System;
using System.Collections.Generic;

namespace NewProject2022.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
         public IEnumerable<Command> GetAllCommands()
         {
             var commands = new List<Command>
             {
                 new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"},
                 new Command{Id=1, HowTo="Cut bread", Line="Get a knife", Platform="knife & chopping board"},
                 new Command{Id=2, HowTo="Make cup of tea", Line="Place teabag in cup", Platform="Kettle & cup"}
             };

             return commands;
         }



         public Command GetCommandById(int id)
         {
             return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan" };
         }
     
        public IEnumerable<Command> GetAppCommands()
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}