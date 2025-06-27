﻿using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer;

namespace DataLayer
{
    public class CustomerDAO
    {
        static List<Customer> customers = new List<Customer>();
        private bool isGenerated = false;
        public List<Customer> GenerateSampleDataset()
        {
            if(isGenerated) {
                return customers;
            }

            customers.Add(new Customer()
            {
                CustomerID = 1,
                CompanyName = "Công ty Thành Đạt",
                ContactName = "Nguyễn Hoài Nam",
                ContactTitle = "Nhân viên hành chính",
                Address = "201 Nguyễn Văn Tăng, Thủ Đức",
                Phone = "0954584559"
            });

            customers.Add(new Customer()
            {
                CustomerID = 2,
                CompanyName = "Công Ty An Nhàn",
                ContactName = "Nguyễn Thị Thường",
                ContactTitle = "Tổng giám đốc",
                Address = "32 Đỗ Xuân Hợp, Q.5",
                Phone = "0915832197"
            });

            customers.Add(new Customer()
            {
                CustomerID = 3,
                CompanyName = "Công Ty Thinh Phát",
                ContactName = "Trần Văn Hưng",
                ContactTitle = "Nhân viên kế toán",
                Address = "66 Đinh Bộ Lĩnh, Q.Bình Thạnh",
                Phone = "0933148392"
            });

            customers.Add(new Customer()
            {
                CustomerID = 4,
                CompanyName = "Công ty Hướng Dương",
                ContactName = "Trần Thái Phong",
                ContactTitle = "Bảo vệ",
                Address = "12 Trườg Thạnh, Q.Tân Phú",
                Phone = "0966127534"
            });

            customers.Add(new Customer()
            {
                CustomerID = 5,
                CompanyName = "Công Ty Hải Sen",
                ContactName = "Trần Thái Long",
                ContactTitle = "Quản lý dự án",
                Address = "288 Lê Hồng Phong, Q.3",
                Phone = "0988115421"
            });

            isGenerated = true;
            return customers;
        }

        public List<Customer> GetCustomers()
        {
            return customers;
        }

        public bool AddCustomer(Customer customer)
        {
            Customer c = customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
            if (c != null)
            {
                return false;
            }

            customers.Add(customer);
            return true;
        }

        public bool RemoveCustomer(int customerId)
        {
            Customer c = customers.FirstOrDefault(c => c.CustomerID == customerId);
            if (c == null)
            {
                return false;
            }

            customers.Remove(c);
            return true;
        }

        public Customer SearchCustomer(int customerId)
        {
            return customers.FirstOrDefault(c => c.CustomerID == customerId);
        }

        public bool UpdateCustomer(Customer customer)
        {
            Customer c = customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
            if (c == null)
            {
                return false;
            }

            c.CompanyName = customer.CompanyName;
            c.ContactName = customer.ContactName;
            c.ContactTitle = customer.ContactTitle;
            c.Address = customer.Address;
            c.Phone = customer.Phone;

            return true;
        }
    }
}
