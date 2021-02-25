using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarkerAssignment5.Models
{
    public interface IBookStoreRepository
    {
        IQueryable<Project> Projects { get; }
    }
}
