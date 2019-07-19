using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApp.Models
{
    public class IndexViewModel
    {
        public List<FormRecord> formRecords { get; set; }
    }

    public class FormRecord
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime ToDate { get; set; }

        public DateTime FromDate { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FavoriteDrink { get; set; }
        public decimal FavoriteNumber { get; set; }
    }
}