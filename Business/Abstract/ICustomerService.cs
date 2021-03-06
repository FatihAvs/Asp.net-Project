using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        List<Customer> GetById();
        public void Add();
        public void Delete();
        public void Update();
    }
}
