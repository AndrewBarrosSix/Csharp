﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1608_EFDatabaseFirst.Controller
{
    class PersonController
    {

        void Inserir(Person p)
        {

            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            contexto.Person.Add(p);
            contexto.SaveChanges();

        }

       List<Person> ListarTodosPerson()
        {

            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Person.ToList();

        }

        Person BuscarPorId(int id)
        {

            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Person.Find(id);

        }

        void Excluir(int id)
        {

            Person pcExcluir = BuscarPorId(id);
            
            if(pcExcluir != null)
            {
                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Person.Remove(pcExcluir);
                contexto.SaveChanges();
            }
        }
    }


}
