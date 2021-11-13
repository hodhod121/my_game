using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyGame.Models;

namespace WebApplication1.Utility
{
    public class TempResult
    {

        public string GetResult(ref DoctorModel _myModel)
        {
            MyModel randomModel = new MyModel();
            randomModel.GetGuessNumber();

            try
            {

                return $"{_myModel.temperature}";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
