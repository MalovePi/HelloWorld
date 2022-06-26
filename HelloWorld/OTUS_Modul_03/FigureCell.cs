﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Modul_03
{
    class FigureCell
    {
        public int axisX;
        public int axisY;
        public char charCell;

        public void DrawFigureCells()
        {
            Console.SetCursorPosition(axisX, axisY);
            Console.Write(charCell);
        }
        public void HideFigureCells()
        {
            Console.SetCursorPosition(axisX, axisY);
            Console.WriteLine(' ');
        }

        public FigureCell(int a,  int b, char symbol)
        {
            axisX = a;
            axisY = b;
            charCell = symbol;
        }

        public void MoveCalls(DirectinEnums directin)
        {
            switch (directin)
            {
                case DirectinEnums.Down:
                    axisY += 1;
                    break;
                case DirectinEnums.Left:
                    axisX -= 1;
                    break;
                case DirectinEnums.Right:
                    axisX += 1;
                    break;              
            }
        }        
    }
}