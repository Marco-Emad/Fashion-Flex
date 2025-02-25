﻿using Fashion_Flex.Models;

namespace Fashion_Flex.Repository
{
    public interface IOrderItemRepository
    {
        public void Add(Order_Item obj);
        public void Update(Order_Item obj);
        public void Delete(int id);
        public Order_Item GetById(int id);
        public List<Order_Item> GetAll();
        public bool OrderItemExist(int orderId, int productId);
        public Order_Item GetByProductAndOrderId(int orderId, int productId);
        public List<Order_Item> GetByOrderId(int orderId);

		public void Save();
    }
}