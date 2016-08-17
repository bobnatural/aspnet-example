using NameDirectoryService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NameDirectoryService.DAL
{
    interface INameDirectoryService
    {
        List<NameDirectory> getAllRows();

        void addNameDirectory(NameDirectory nd);

        void deleteNameDirectoryById(int id);

        void deleteAll();
    }
}
