﻿using MongoDB.Bson;

namespace Villa.DTO.Dtos.VideoDtos
{
    public class UpdateVideoDto
    {
        public ObjectId Id { get; set; }
        public string VideoUrl { get; set; }
    }
}
