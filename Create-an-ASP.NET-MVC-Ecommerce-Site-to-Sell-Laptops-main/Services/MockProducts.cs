using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Models;

namespace WebProject.Services
{
    public class MockProducts : IRepository<Products>
    {
        List<Products> _product;
        public MockProducts()
        {
            _product = new List<Products>() {
                new Products()
                {
                    ID = 1,
                    Name = "Lenovo Labtop",
                    Price = 1119.84,
                    Details = "Lenovo Laptop Chromebook 2-in-1 Laptop Quad-Core Processor, 4GB RAM, 32GB eMMC, Google Chrome OS",
                    Image = "1.jpg",
                    Count=2
                },
                 new Products()
                {
                    ID = 2,
                    Name = "Microsoft Surface Laptop",
                    Price = 5999.00,
                    Details = "Microsoft Surface Laptop 3 - 15 Inch Touch Screen, AMD Ryzen 5 Microsoft Surface Edition," +
                    " 256 GB, 16 GB RAM, Windows - Matte Black",
                    Image = "2.jpg",
                    Count=3
                },
                  new Products()
                {
                    ID = 3,
                    Name = "HP15 Labtop",
                    Price = 2633.00,
                    Details = "NB- HP15 -DA2003NX - CORE I5 -10210U -1.60 GHZ -4GB RAM -1000 GB -WIN 10 -15.6 HDD -BLACK",
                    Image = "3.jpg",
                    Count=1
                },
                   new Products()
                {
                    ID = 4,
                    Name = "Dell Labtop",
                    Price = 1675,
                    Details = "Dell Latitude 3410 Intel Core i3-10110U, 4GB DDR4, 1TB HDD, 14.0″ HD, Integrated Intel UHD," +
                    " Ubuntu Linux – LATI-3410-I3-DOS",
                    Image = "4.jpg",
                    Count=2
                },
                    new Products()
                {
                    ID = 5,
                    Name = "HUAWEI Labtop",
                    Price = 2799.00,
                    Details = "HUAWEI MateBook 14, Laptop 2K FullView Display Ultrabook, AMD Ryzen 5, 8GB RAM, 256GB PCIe SSD," +
                    " Fingerabdrucksensor, Huawei Share, Windows 10 Home, Space Gray",
                    Image = "5.jpg",
                    Count=1
                },
                 new Products()
                {
                    ID = 6,
                    Name = "Samsung Labtop",
                    Price = 3746.85,
                    Details = "SAMSUNG GALAXY 13.3 4K ULTRA HD TOUCH-SCREEN CHROMEBOOK - INTEL CORE I5 - 8GB MEMORY - 256GB SSD - MERCURY GRAY",
                    Image = "6.jpg",
                    Count=2
                },
                 new Products()
                {
                    ID = 7,
                    Name = "ASUS Labtop",
                    Price = 5577.22,
                    Details = "ASUS ROG Strix G512 15.6, Full HD 144Hz Gaming Notebook Computer, Intel Core i7-10750H 2.6GHz, 8GB RAM, 512GB SSD," +
                    " NVIDIA GeForce GTX 1650 Ti 4GB, Windows 10 Home",
                    Image = "7.jpg",
                    Count=3
                },
                new Products()
                {
                    ID = 8,
                    Name = "MSI BRAVO Labtop",
                    Price = 4293.98,
                    Details = "MSI BRAVO 15 A4DDR 15.6, FHD (1920x1080) 144Hz IPS AMD RYZEN 7 4800H 16GB RAM 512GB SSD AMD RADEON RX5500M 4GB WIN 10 HOME",
                    Image = "8.jpg",
                    Count=4
                },
                new Products()
                {
                    ID = 9,
                    Name = "Razer Blade 15 Labtop",
                    Price = 5099.77,
                    Details = "Razer Blade 15 Base Gaming Laptop 2020: Intel Core i7-10750H 6-Core, NVIDIA GeForce GTX 1660 Ti, 15.6, FHD 1080p 120Hz," +
                    " 16GB RAM, 256GB SSD, CNC Aluminum, Chroma RGB Lighting, Thunderbolt 3, Black",
                    Image = "9.jpg",
                    Count=1
                },
                new Products()
                {
                    ID = 10,
                    Name = "HP 15 Labtop",
                    Price = 1998.00,
                    Details = "HP 15-da1051nx Laptop, 15.6 HD, Intel core i3-8145U, dual core, 4GB RAM, 1TB HDD, Intel UHD Graphics, DVD-RW, DOS, Black",
                    Image = "10.jpg",
                    Count=2
                }
            };
        }
        public bool Add(Products item)
        {
            try
            {
                Products product = item;
                product.ID = _product.Max(x => x.ID) + 1;
                _product.Add(item);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Products item)
        {
            throw new NotImplementedException();
        }


        public bool Edit(Products item)
        {
            throw new NotImplementedException();
        }

        public Products Get(int id)
        {
            return _product.FirstOrDefault(x => x.ID == id);
        }

        public IEnumerable<Products> GetAll()
        {
            return _product.ToList();
        }

    }
}