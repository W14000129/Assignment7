using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp3.Models
{
	public class Notes
	{
		public int Id { get; set; }
		[Required]
		public string Title { get; set; }
		public string Note { get; set; }
		public string CreatedOn { get; set; }
		public int CategoryId { get; set; }
		public bool isDeleted { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
		public Category Category { get; set; }
	}

	public class CategoryDTO
	{

		public int Id { get; set; }
		[Required]
		public string Title { get; set; }
		public string Note { get; set; }
		public string CreatedOn { get; set; }
		public int CategoryId { get; set; }
		public bool isDeleted { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
		public Category Category { get; set; }
	}

	public class UserDTO
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Email { get; set; }
		public string UserName { get; set; }
		public string CategoryName{ get; set; }
	}
}