using System;
using System.Collections.Generic;
using System.Text;

namespace ICEEX.ApiTest.Models.InputModels
{
    public class GetDepthInput : InputDto
    {
        string symbol;
        public string Symbol
        {
            set
            {
                symbol = value;
            }
            get
            {
                return symbol.Replace("-", "/");
            }
        }

        public int Size { set; get; } = 200;
    }
}
