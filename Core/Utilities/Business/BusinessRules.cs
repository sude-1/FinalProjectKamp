using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                //parametreyle gönderiğimiz iş kurallarından başarısız olanları bussinese haber ediyoruz
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
