using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CalculationTest.Models;

namespace CalculationTest.Services
{
    public class CalculationService : ICalculationService
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        public List<RegisterDto> GetAll()
        {
           var registerList = db.Registers.ToList();
//           List<RegisterViewModel> viewList = new List<RegisterViewModel>();
//            for(var reg in registerList){
//                viewList.Add(new RegisterViewModel{
//                    RegisterId = reg.Id,
//                    Cash = reg.Cash,
//                    Visa = reg.Visa,
//                    Amex = reg.Amex,
//                    Mastercard = reg.Mastercard,
//                    Discover = reg.Discover
//                });
//           }
           return registerList.Select(reg => ToDto(reg)).ToList();
        }

        private static RegisterDto ToDto(Register reg)
        {
            return new RegisterDto
            {
                RegisterId = reg.RegisterId,
                Cash = reg.Cash,
                Visa = reg.Visa,
                Amex = reg.Amex,
                Mastercard = reg.Mastercard,
                Discover = reg.Discover,
                Total = reg.Cash + reg.Visa + reg.Amex + reg.Mastercard + reg.Discover

            };
        }

        public RegisterDto FindById(int id)
        {
            var register = db.Registers.Find(id);
            return register != null ? ToDto(register) : null;
            
        }

        //public Register SaveRegister(int id)
        //{
        //  // i have no idea
        //}

        //public Register CreateRegister()
        //{
           
        //}

        


    }
}