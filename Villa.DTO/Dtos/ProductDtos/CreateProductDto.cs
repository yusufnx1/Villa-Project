﻿namespace Villa.DTO.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string Title { get; set; }
        public int BadroomCount { get; set; }
        public int BathroomCount { get; set; }
        public int Area { get; set; }
        public int Floor { get; set; }
        public int ParkingCount { get; set; }
    }
}
