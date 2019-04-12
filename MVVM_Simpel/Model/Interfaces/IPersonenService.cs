using Model.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Interfaces
{
    public interface IPersonenService
    {
        IEnumerable<Person> GetPersonen();
    }
}
