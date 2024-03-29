﻿using System;
using MongoDB.Bson.Serialization.Attributes;

namespace FreeCourse.Services.Catalog.Models
{
	public class Course
	{
		[BsonId]
		[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
		public string Id { get; set; }

		public string Name { get; set; }

		[BsonRepresentation(MongoDB.Bson.BsonType.Decimal128)]
		public float Price { get; set; }

		public string UserId { get; set; }

		public string Picture { get; set; }

		public DateTime CreatedTime { get; set; }

		public Feature Feature { get; set; }

		public string CategoryId { get; set; }

		public Category Category { get; set; }


	}
}

