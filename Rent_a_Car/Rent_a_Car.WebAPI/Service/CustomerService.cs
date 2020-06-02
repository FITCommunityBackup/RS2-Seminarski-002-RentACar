﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rent_a_Car.WebAPI.Database;
using Rent_a_Car.WebAPI.Service;
using RentaCar.Data.Requests.Customer;
using RentACar.WebAPI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Service
{
    public class CustomerService : ICustomerService
    {
        protected readonly RentaCarContext _context;
        protected readonly IMapper _mapper;

        public CustomerService(RentaCarContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<CustomerRequest> Get(CustomerSearchRequest request)
        {
            var query = _context.Set<Customer>().Include(x=>x.City).AsQueryable();

            if(!string.IsNullOrWhiteSpace(request.FirstName) || !string.IsNullOrWhiteSpace(request.LastName))
            {
                query = query.Where(x => x.LastName.StartsWith(request.LastName) || x.FirstName.StartsWith(request.FirstName));
            }

            //if(!string.IsNullOrWhiteSpace(search.CityName))
            //{
            //    query = query.Where(x => x.City.CityName == search.CityName);
            //}
            //query = query.OrderBy(x => x.City.CityName);

            return _mapper.Map<List<CustomerRequest>>(query.ToList());
        }

        private static string GenerateSalt()        
        {
            var buffer = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buffer);
            return Convert.ToBase64String(buffer);
        }
        private static string GenerateHash(string salt, string password)      
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public CustomerRequest Insert(CustomerUpsert request)
        {
            var entity = _mapper.Map<Customer>(request);

            if(request.Password != request.PasswordConfirm)
            {
                throw new Exception("Password and password confirm not matched !");
            }
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            _context.Add(entity);
            _context.SaveChanges();

            foreach (var item in request.Role)
            {
                CustomerRoles customerRoles = new CustomerRoles();

                customerRoles.CustomerId = entity.CustomerId;
                customerRoles.RoleId = item;
                _context.CustomerRoles.Add(customerRoles);
            }
            _context.SaveChanges();

            return _mapper.Map<CustomerRequest>(entity);
        }

        public CustomerRequest Update(int id, CustomerUpsert request)
        {
            var entity = _context.Customer.Find(id);

            _context.Customer.Attach(entity);
            _context.Customer.Update(entity);

            _mapper.Map(request, entity);
            _context.SaveChanges();

            return _mapper.Map<CustomerRequest>(entity);
        }

        public Customer Authenticate(CustomerLoginRequest request)
        {
            var customer = _context.Customer.FirstOrDefault(x => x.Username == request.Username);

            if(customer != null)
            {
                var newHash = GenerateHash(customer.PasswordSalt, request.Password);

                if(customer.PasswordHash==newHash)
                {
                    return _mapper.Map<Customer>(customer);
                }
            }
            return null;
        }

        public CustomerRequest GetById(int id)
        {
            return _mapper.Map<CustomerRequest>(_context.Customer.Find(id));
        }
    }
}
