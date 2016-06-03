﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Author : Chenyuan Xie
 * Date : June 2th, 2016
 * Date Modified: Jun 3th, 2016
 * Description : Assignment 1
 * Version : 0.0.5 - Added Documentation for everything.
 */
namespace Assignment_1
{
    /**
     * This class is the driver class for the program
     * 
     * @class program
     */
    class Program
    {
        /**
         * the main method for my driver class
         * 
         * @method Main
         * @param {sting[]} args
         */
        static void Main(string[] args)
        {
            Hero Slasher = new Hero();
            Slasher.Name = "Slasher";
            Slasher.Show();
            Slasher.Fight();
            
            

        }
    }
}
