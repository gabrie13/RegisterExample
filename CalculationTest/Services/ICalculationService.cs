using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CalculationTest.Models;


namespace CalculationTest.Services
{
    interface ICalculationService
    {
        List<RegisterDto> GetAll();

        RegisterDto FindById(int id);


    }

    //interface CalculationService : ICalculationService
    //{
    //    Register SaveRegister(int id);
    //    Register CreateRegister(int id);
    //}
    
}
