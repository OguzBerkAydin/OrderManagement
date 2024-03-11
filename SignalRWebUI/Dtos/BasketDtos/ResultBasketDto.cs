﻿using EntityLayer.Entities;

namespace SignalRWebUI.Dtos.BasketDtos
{
    public class ResultBasketDto
    {
        public int BasketID { get; set; }
        public decimal Price { get; set; }
        public decimal Count { get; set; }
        public decimal TotalPrice { get; set; }
        public int ProductId { get; set; }
        public int RestaurantTableId { get; set; }
        public string ProductName { get; set; }

    }

}
