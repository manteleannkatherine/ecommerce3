using ECommerce1.Data.Enums;
using ECommerce1.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce1.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();
                context.Database.EnsureCreated();

                #region Gender
                if (!context.Genders.Any())
                {
                    context.Genders.AddRange(new List<Gender>()
                    {
                        new Gender()
                        {
                            Title = "Men"
                        },
                        new Gender()
                        {
                            Title = "Women"
                        },
                    });

                    context.SaveChanges();
                }
                #endregion Gender

                #region Customers
                if (!context.Customers.Any())
                {
                    context.Customers.AddRange(new List<Customers>()
                    {
                        new Customers()
                        {
                            CustomerFirstName = "Will",
                            CustomerLastName = "Smith",
                            Image = "https://dotnethow.net/images/actors/actor-5.jpeg"
                }
                    }); ;

                    context.SaveChanges();
                }
                #endregion Customers

                #region Employees
                if (!context.Employees.Any())
                {
                    context.Employees.AddRange(new List<Employees>()
                    {
                        new Employees()
                        {
                            EmployeeFirstName = "Jhon",
                            EmployeeLastName = "Smith",
                            Image = "https://dotnethow.net/images/actors/actor-1.jpeg"
                }
                    }); ;

                    context.SaveChanges();
                }
                #endregion Employees

                #region Status
                if (!context.Statuses.Any())
                {
                    context.Statuses.AddRange(new List<Status>()
                    {
                        new Status()
                        {
                            Title = "Active"
                        },
                        new Status()
                        {
                            Title = "Inactive"
                        },
                        new Status()
                        {
                            Title = "Phase-out"
                        },
                    });

                    context.SaveChanges();
                }
                #endregion Status

                #region Product Category
                if (!context.ProductCategories.Any())
                {
                    context.ProductCategories.AddRange(new List<ProductCategory>()
                    {
                        new ProductCategory()
                        {
                            Title = "Shoes"
                        },
                        new ProductCategory()
                        {
                            Title = "Clothing"
                        },
                        new ProductCategory()
                        {
                            Title = "Accessories"
                        },
                    });

                    context.SaveChanges();
                }
                #endregion Product Category

                #region Product
                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            Name = "Adidas",
                            Description = "Adidas",
                            ProductCategoryId = (int)ProductCategoryEnum.Clothing,
                            StatusId = (int)StatusEnum.Active,
                            DateCreated = DateTime.Now,
                            GenderId = (int)GenderEnum.Men
                }
                    }); ;

                    context.SaveChanges();
                }
                #endregion Product

            }
        }
    }
}
