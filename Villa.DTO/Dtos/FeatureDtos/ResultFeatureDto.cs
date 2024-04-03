﻿using MongoDB.Bson;

namespace Villa.DTO.Dtos.FeatureDtos
{
    public class ResultFeatureDto
    {
        public ObjectId Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Square { get; set; }
        public string Contract { get; set; }
        public string Payment { get; set; }
        public string Safety { get; set; }
    }
}
