﻿using Fashion_Flex.Models;

namespace Fashion_Flex.Repository
{
    public interface IOrderRepository
    {
        public void Add(Order obj);
        public void Update(Order obj);
        public void Delete(int id);
        public Order GetOrderById(int id);
        public List<Order> GetOrdersByCustomerId(int id);
        public List<Order> GetAll();
        void Save();
        public bool updateOrderStatus(int orderId, string status);
        public Order GetCustomerCurrOrder(int customerId);
    }
}
