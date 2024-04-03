﻿using MongoDB.Bson;

namespace Villa.DTO.Dtos.ContactDtos
{
    public class ResultContactDto
    {
        public ObjectId Id { get; set; }
        public string MapUrl { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
