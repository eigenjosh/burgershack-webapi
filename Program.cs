using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using burgershack_c.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace burgershack_c
{
    public class Program
    {

        //VERY VERY VERY BAD NEVER DO THIS
        public static List<Side> Sides = new List<Side>() {
                new Side() {
                    Id = 1,
                    Name = "Straight Up",
                    Description = "A plain old side \"seasoned\" to perfection",
                    Price = 3.99 }
        };
        public static List<Drink> Drinks = new List<Drink>() {
                new Drink() {
                    Id = 1,
                    Name = "Straight Up",
                    Description = "A plain old drink \"seasoned\" to perfection",
                    Price = 1.99 }
        };
        public static List<Burger> Burgers = new List<Burger>() {
                new Burger() {
                    Id = 1,
                    Name = "Straight Up",
                    Description = "A plain old burger seasoned to perfection",
                    Price = 9.99 },
                new Burger() {
                    Id = 2,
                    Name = "Cheese Burger",
                    Description = "Straight up with cheese, (Choose One: Provolone, Gouda, Munster, Swiss, Cheddar, Merican)",
                    Price = 10.99 } };


        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
