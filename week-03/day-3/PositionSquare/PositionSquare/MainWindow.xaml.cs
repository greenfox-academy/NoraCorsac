﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace PositionSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            int x = 50;
            int y = 20;
            PositionSquare(foxDraw, x, y);
            // create a square drawing function that takes 2 parameters:
            // the x and y coordinates of the square's top left corner
            // and draws a 50x50 square from that point.
            // draw 3 squares with that function.            

        }
        public static void PositionSquare(FoxDraw foxDraw, int x, int y)
        {
            {
                foxDraw.StrokeColor(Colors.LightSeaGreen);
                for (int i = 1; i < 4; i++)
                {
                    foxDraw.DrawRectangle(x * i, y * i, x, x);
                }
            }
        }
    }
}