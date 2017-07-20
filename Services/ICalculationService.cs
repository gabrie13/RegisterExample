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

        RegisterDto Create(RegisterDto register);

        RegisterDto Save(RegisterDto register);

    }

    
}
